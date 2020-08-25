## ResistanceVR

[![77777](https://user-images.githubusercontent.com/39264266/40175276-8db84a28-5a12-11e8-9509-7dc571c18f35.jpg)](https://www.youtube.com/watch?v=jbilbZStmxI&t=117s)


↑ 위 사진을 클릭하면 해당 유튜브 페이지로 이동합니다.

[Resistance VR 카드보드용 게임 플레이 영상](https://www.youtube.com/watch?v=4ycKzkzdsoY&t=216sc)

# 개요
[Resistance VR 기획서](https://github.com/alsdn14/Resistance/blob/gh-pages/VR%20Resistance.pdf)

VR Cardboard와 Bluetooth 컨트롤러를 이용해서 하는 게임으로 간단한 FPS기반의 인던형식의 게임 입니다.


## 주요 기술

* 참여도 : 개인프로젝트
* UNITY, Visual Studio
* C, C#
* Git(Source Tree), GitHub

## Contents

### AIM 과 AIM 게이지


* 커서 이미지(CursorGageImage)와 카메라 중앙지점을 저장하는 Vector3 변수(ScreenCenter) 
커서게이지를 증가시키기 위한 변수(GageTimer) 를 선언한 후
카메라 중앙지점을 저장하는 Vector3 변수에 카메라 높이 픽셀과 넓이픽셀의 1/2을 저장하고 ( 카메라중앙 )

* 그 카메라 중앙좌표에 Raycast를 생성하고,
레이캐스트의 충돌좌표를 받아 충돌상태를 확인한후 그 충돌 대상의 태그가 "BOX" 일 경우
커서게이지 이미지의 Fillamount 값은 GageTimer 값과 같게 하고 GageTimer 를 5초동안 GageTimer 를 1로 증가시킵니다.
GageTimer 가 1이 될경우 씬이 넘어가고 
충돌 대상의 태그가 "BOX" 가 아닐경우 GageTimer 을 0으로 하는 식으로 구현했습니다.


```

    public Image CursorGageImage;
    
    private Cardboard MagnetButton;
    
    public Vector3 ScreenCenter;
    
    private float GageTimer;
    
    void Start () {
    
        ScreenCenter = new Vector3(Camera.main.pixelWidth / 2,
                                   Camera.main.pixelHeight / 2);
				   
        MagnetButton = GetComponent<Cardboard>();
	
	}
	
    void Update() {
    
        Ray ray = Camera.main.ScreenPointToRay(ScreenCenter);
	
        RaycastHit hit;
	
        CursorGageImage.fillAmount = GageTimer;
	
        if (Physics.Raycast(ray, out hit, 100.0f))
	
        {
	
            if (hit.collider.CompareTag("BOX"))
	    
            { 
	    
            GageTimer += 1.0f / 5.0f * Time.deltaTime;
	    
                if (GageTimer >= 1 || MagnetButton.Triggered)
		
                {
                    Application.LoadLevel(3);
		    
                    GageTimer = 0;
                }
            }
	else
            GageTimer = 0;
		    
        }        
    }

```


### 바닥에 떨어진 무기 교체

* 총들을 메인카메라 자식으로 두고 위치를 잡아둔다음
Void Start 부분에
권총을 제외한 총 오브젝트를 비활성화 시킨후

* OntriggerEnter 함수를 이용하여 Collider가 Player태그를 가지고있는 오브젝트와 충돌이 있을경우
Myweapon 오브젝트에 올려놓은 총을 제외한 다른 총들을 비활성화 시키는 방식으로 총 교체를 구현하였습니다.
다른 총들에도 같은 스크립트를 씌워 오브젝트만 다르게 하기위해 Public 으로 변수선언을 하였습니다.



```
    public GameObject MyWeapon;
    
    public GameObject WeaponOntheGround;
    
    public GameObject FirstWeapon;
    
    public GameObject SecondWeapon;
    
    public GameObject ThirdWeapon;
    
    public GameObject FifthWeapon;
    
    void Start()
    {

        MyWeapon.SetActive(false);
	
        SecondWeapon.SetActive(false);
	
        ThirdWeapon.SetActive(false);
	
        FifthWeapon.SetActive(false);

    }

    void OnTriggerEnter(Collider _collider)
    
    {
        Debug.Log("Trigger M4!");        
	
        if (_collider.gameObject.tag == "Player")        
        {
	
            SoundManager2.instance.PlaySound();
	    
            MyWeapon.SetActive(true);
	    
            WeaponOntheGround.SetActive(false);
	    
            FirstWeapon.SetActive(false);
	    
            SecondWeapon.SetActive(false);
	    
            ThirdWeapon.SetActive(false);
	    
            FifthWeapon.SetActive(false);
	    
        }        
    }
   
```
