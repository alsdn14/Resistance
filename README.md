## ResistanceVR

[![77777](https://user-images.githubusercontent.com/39264266/40175276-8db84a28-5a12-11e8-9509-7dc571c18f35.jpg)](https://www.youtube.com/watch?v=jbilbZStmxI&t=117s)


↑ 위 사진을 클릭하면 해당 유튜브 페이지로 이동합니다.

# 개요

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


# Header 1
## Header 2
### Header 3

- Bulleted
- List

1. Numbered
2. List

**Bold** and _Italic_ and `Code` text

[Link](url) and ![Image](src)
```

For more details see [GitHub Flavored Markdown](https://guides.github.com/features/mastering-markdown/).

### Jekyll Themes

Your Pages site will use the layout and styles from the Jekyll theme you have selected in your [repository settings](https://github.com/alsdn14/Resistance/settings). The name of this theme is saved in the Jekyll `_config.yml` configuration file.

### Support or Contact

Having trouble with Pages? Check out our [documentation](https://docs.github.com/categories/github-pages-basics/) or [contact support](https://github.com/contact) and we’ll help you sort it out.
