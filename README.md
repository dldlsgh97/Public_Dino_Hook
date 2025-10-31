# 🦕 Dino Hook

리팩토링 및 기능 추가 프로젝트입니다. 기존 **Dino Hook**을 기반으로 **Unity Input System** 도입과 전반적인 코드/시스템 개선을 수행했습니다. 2D 횡스크롤 클라이밍 장르로, 주인공이 **갈고리(그래플링 훅)** 를 사용해 맵 상단의 상자에 도달하는 것이 목표입니다.


---

## 🎮 플레이 링크

* itch.io: **[DinoHook](https://dldlsgh97.itch.io/dinohook)**

---

## 🖼️ 스크린샷
<p align="center">
  <img src="https://github.com/user-attachments/assets/a40b66d6-01d8-4a80-90d8-c25f53f5f229" width="600">
  <img src="https://github.com/user-attachments/assets/72332dca-1b91-42f3-b8ed-e06f3b257aac" width="600">
  <img src="https://github.com/user-attachments/assets/c4e5739e-d71f-4cd0-8b06-741ccb03e138" width="600">
</p>




---
## 🧪 실행 영상

> **[🎮 플레이 영상 보러가기](https://youtu.be/x5irSlUr-TE)**

---

## ✨ 프로젝트 개요

* 기존 제작했던 ‘Dino Hook’의 코드를 **리팩토링**하고 **기능을 추가**한 프로젝트
* **레거시 Input** 기반 시스템을 **Unity Input System**으로 전환
* 2D 횡스크롤 **클라이밍** 장르: 갈고리로 이동/등반하여 목표 지점(상자)에 도달

---

## 🧩 변경된 기능 (Refactoring)

### 플레이어 시스템

* **이동**

  * 레거시 인풋 → **Unity Input System** 전환
  * 이동 방향 바라보기 로직 리팩토링
  * 문서: [인풋시스템을 이용한 플레이어 이동](https://www.notion.so/21fd2d17037e809785d9cd9b25df28bc?pvs=21), [플레이어 이동시 이동방향 바라보기](https://www.notion.so/211d2d17037e81bf8ab9e55055f880de?pvs=21)
* **점프**

  * 레거시 인풋 → **Unity Input System** 전환
  * 문서: [인풋시스템을 이용한 플레이어 이동](https://www.notion.so/21fd2d17037e809785d9cd9b25df28bc?pvs=21)
* **갈고리 발사 및 부착**

  * 발사 스크립트 최적화 및 코드 정리
  * 문서: [플레이어 그래플링훅 리팩토링](https://www.notion.so/22cd2d17037e80ec9118f7cae71833d3?pvs=21)

### 메인 시스템

* **메인 메뉴 UI 팝업** 리팩토링 → 사용성 개선
  문서: [메인메뉴 변경](https://www.notion.so/234d2d17037e8093806fdfb7dedbfb06?pvs=21)
* **게임오버 시스템** 리팩토링
  문서: [게임 오버 _1](https://www.notion.so/_1-233d2d17037e8009a602effb113f0d1d?pvs=21), [게임오버_2](https://www.notion.so/_2-234d2d17037e80eeaec9cc4c202d3ccf?pvs=21)

---

## ➕ 추가된 기능 (New Features)

### 옵션/시스템

* **사운드 시스템 추가**
  문서: [사운드 기능 추가](https://www.notion.so/241d2d17037e802982d7e2358360c202?pvs=21)
* **사운드 옵션(볼륨 제어 등)**
  문서: [사운드 옵션기능](https://www.notion.so/23ad2d17037e80a198a1c438df51b9f1?pvs=21)
* **일시정지(Pause) 메뉴**
  문서: [게임 일시정지 메뉴 추가](https://www.notion.so/241d2d17037e80219f66ccd2b1e1a746?pvs=21)

### 디테일/콘텐츠

* **캐릭터 선택 기능**
  문서: [캐릭터 선택기능 추가](https://www.notion.so/263d2d17037e8018bec8fae745329e20?pvs=21)
* **스토리 설명 슬라이드**
  문서: [스토리설명 슬라이드 기능 추가](https://www.notion.so/242d2d17037e800a9548e8b45e8c6541?pvs=21)
* **메인메뉴 배경 추가**
  문서: [메인메뉴 배경 추가](https://www.notion.so/242d2d17037e809e88ddc017626044f3?pvs=21)
* **맵 리메이크**
  문서: [맵 리메이크](https://www.notion.so/279d2d17037e800f8cd3fb4ddb2673d1?pvs=21)
* **에셋 출처(Credits) 팝업**
  문서: [에셋 출처 팝업 구현](https://www.notion.so/28fd2d17037e80f492c2ec6672a1f6fd?pvs=21)
* **WebGL 빌드**
  문서: [WebGL 빌드](https://www.notion.so/WebGL-295d2d17037e80aebbf1d3fcc649e49f?pvs=21)
* **오류 수정**
  문서: [플레이어 애니메이션 오류 수정](https://www.notion.so/27ad2d17037e80e3a883e548b614a34f?pvs=21)

---


## 🛠️ 기술 스택

* **Engine**: Unity (Input System 사용)
* **Platform**: PC, WebGL
* **Language**: C#
* **UI**: Unity UI (UGUI)

---

## 🎯 핵심 개선 포인트

* 입력 처리 **일원화**(레거시 → Input System), 이벤트 기반 구조로 전환
* **애니메이션 제어** 신뢰성 개선 (상태 전이/조건 정리)
* **UI 흐름 정돈**: 메인메뉴/일시정지/게임오버 등 핵심 UX 정리
* **코드 가독성** 및 **유지보수성 향상**

---

## 🎮 (예시) 조작법

| 동작     | 키 (예시) |
| ------ | ------ |
| 이동     | A / D  |
| 점프     | Space  |
| 갈고리 발사 | E      |

---

## 🧑‍🔧 Trouble Shooting

<details>
<summary><b>플레이어 애니메이션 오류</b></summary>

* **현상**: 점프 시 애니메이션이 정상 재생되지 않음
* **원인**: 점프 직후 `is_Ground = true` 이며, `FixedUpdate`에서 바로 `anim.SetBool("jump", false)` 되어 애니메이션이 보이지 않음
* **해결**: 착지 후 y 속도가 0 근처일 때만 `jump`를 false로 전환

```csharp
if (groundCheck.is_Ground && Mathf.Abs(rigid.velocity.y) < 0.01f)
{
    anim.SetBool("jump", false);
}
```

</details>

<details>
<summary><b>플레이어 애니메이션 오류_2</b></summary>

* **현상**: 캐릭터 수 증가 이후 전이(Transition)로 인한 끊김/지연
* **해결**: Animator 전이 설정 최적화

  * `Has Exit Time`: 체크 해제
  * `Transition Duration`: 0
  * `Transition Offset`: 0
  * `Interruption Source`: `Current State` 또는 `Current State Then Next State`
  * `Ordered Interruption`: 체크 해제

</details>

---

## 📚 문서 모음

* 입력/이동: [인풋시스템을 이용한 플레이어 이동](https://www.notion.so/21fd2d17037e809785d9cd9b25df28bc?pvs=21)
* 이동 방향 보기: [플레이어 이동시 이동방향 바라보기](https://www.notion.so/211d2d17037e81bf8ab9e55055f880de?pvs=21)
* 훅 리팩토링: [플레이어 그래플링훅 리팩토링](https://www.notion.so/22cd2d17037e80ec9118f7cae71833d3?pvs=21)
* 메인메뉴: [메인메뉴 변경](https://www.notion.so/234d2d17037e8093806fdfb7dedbfb06?pvs=21)
* 게임오버: [게임 오버 _1](https://www.notion.so/_1-233d2d17037e8009a602effb113f0d1d?pvs=21) · [게임오버_2](https://www.notion.so/_2-234d2d17037e80eeaec9cc4c202d3ccf?pvs=21)
* 사운드: [사운드 기능 추가](https://www.notion.so/241d2d17037e802982d7e2358360c202?pvs=21) · [사운드 옵션기능](https://www.notion.so/23ad2d17037e80a198a1c438df51b9f1?pvs=21)
* 일시정지: [게임 일시정지 메뉴 추가](https://www.notion.so/241d2d17037e80219f66ccd2b1e1a746?pvs=21)
* 캐릭터 선택: [캐릭터 선택기능 추가](https://www.notion.so/263d2d17037e8018bec8fae745329e20?pvs=21)
* 스토리 슬라이드: [스토리설명 슬라이드 기능 추가](https://www.notion.so/242d2d17037e800a9548e8b45e8c6541?pvs=21)
* 메인메뉴 배경: [메인메뉴 배경 추가](https://www.notion.so/242d2d17037e809e88ddc017626044f3?pvs=21)
* 맵 리메이크: [맵 리메이크](https://www.notion.so/279d2d17037e800f8cd3fb4ddb2673d1?pvs=21)
* 크레딧 팝업: [에셋 출처 팝업 구현](https://www.notion.so/28fd2d17037e80f492c2ec6672a1f6fd?pvs=21)
* WebGL: [WebGL 빌드](https://www.notion.so/WebGL-295d2d17037e80aebbf1d3fcc649e49f?pvs=21)
* 버그 픽스: [플레이어 애니메이션 오류 수정](https://www.notion.so/27ad2d17037e80e3a883e548b614a34f?pvs=21)
