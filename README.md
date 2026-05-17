# RogueLoopKit

A modular mobile roguelike starter kit for Unity 6. RogueLoopKit gives indie teams a production-oriented foundation: decoupled gameplay systems, data-driven progression, and mobile-first defaults you can extend without rewriting core loops.

---

## Features

- **Mobile-ready architecture** — Touch-first input, performance-conscious update patterns, and scalable scene flow for iOS and Android builds.
- **Modular gameplay systems** — Loosely coupled modules with clear boundaries so you can enable, replace, or extend systems independently.
- **Enemy AI** — Composable enemy behavior built for wave-based combat and roguelike pacing.
- **Skill system** — Runtime skill execution with cooldowns, targeting hooks, and integration points for VFX and UI feedback.
- **Upgrade system** — Run-based and meta progression hooks designed for roguelike reward loops.
- **UI framework** — Reusable screens, HUD widgets, and event-driven UI wiring for gameplay state.
- **Wave spawning** — Configurable wave definitions with spawn points, pacing, and difficulty scaling.
- **ScriptableObject-based upgrades** — Designer-friendly data assets for stats, perks, and loot tables without code changes.

---

## Tech Stack

| Technology | Role |
|------------|------|
| Unity 6 | Editor and runtime (tested with 6000.2.x) |
| URP 2D | 2D rendering pipeline |
| C# | Gameplay and framework code |
| ScriptableObjects | Upgrades, waves, skills, and balance data |

Additional packages included in the template: **Input System**, **UGUI**, **2D Animation**, and **Timeline**.

---

## Folder Structure

The Unity project lives in `My project/`. The kit is organized around a single root namespace folder under `Assets`:

```
rogue-loop-kit/
├── LICENSE
├── README.md
└── My project/
    ├── Assets/
    │   ├── RogueLoopKit/
    │   │   ├── Core/           # Game loop, events, service locator / bootstrap
    │   │   ├── Player/         # Movement, stats, combat receiver
    │   │   ├── Enemies/        # Enemy entities, health, loot drops
    │   │   ├── AI/             # Behavior trees / state machines, targeting
    │   │   ├── Skills/         # Skill definitions, executors, cooldowns
    │   │   ├── Upgrades/       # Upgrade application, run modifiers
    │   │   ├── Spawning/       # Wave spawner, spawn points, pooling
    │   │   ├── UI/             # HUD, menus, upgrade selection screens
    │   │   └── Data/           # ScriptableObject assets (skills, upgrades, waves)
    │   ├── Scenes/             # Bootstrap, gameplay, and test scenes
    │   └── Settings/           # URP, renderer, and project render settings
    ├── Packages/
    └── ProjectSettings/
```

`RogueLoopKit/` modules are added incrementally as the kit matures. Scenes and URP settings are already in place from the Unity 6 2D (URP) template.

---

## Installation

### Requirements

- [Unity 6](https://unity.com/download) (6000.2.x or newer recommended)
- Unity Hub (optional, recommended)
- Git

### Clone and open

1. Clone the repository:

   ```bash
   git clone https://github.com/<your-org>/rogue-loop-kit.git
   cd rogue-loop-kit
   ```

2. Open the project in Unity Hub:
   - **Add** → select the `My project` folder inside the cloned repository.
   - Unity will import packages from `Packages/manifest.json` on first open.

3. Open the sample scene:
   - `Assets/Scenes/SampleScene.unity`

4. Configure a mobile build target (optional):
   - **File → Build Profiles** (or **Build Settings**)
   - Switch platform to **Android** or **iOS**
   - Adjust **Player Settings** (orientation, safe area, input) for your title

### Using as a starter in an existing project

Copy the `Assets/RogueLoopKit/` folder (once present) into your Unity 6 URP 2D project. Ensure **Input System** and **Universal RP** are installed via the Package Manager, then wire the bootstrap scene from `Assets/Scenes/`.

---

## Roadmap

| Phase | Focus | Status |
|-------|--------|--------|
| 0 | Unity 6 URP 2D template, repo scaffolding | In progress |
| 1 | Core loop, events, player controller | Planned |
| 2 | Enemy AI and wave spawning | Planned |
| 3 | Skills and ScriptableObject upgrades | Planned |
| 4 | UI framework and upgrade selection flow | Planned |
| 5 | Mobile polish, pooling, sample vertical slice | Planned |
| 6 | Documentation, sample content pack | Planned |

Contributions and issue reports are welcome as modules land.

---

## Screenshots

Screenshots will be added as the sample vertical slice is completed.

| Screenshot | Description |
|------------|-------------|
| *Coming soon* | Gameplay — combat and wave loop |
| *Coming soon* | Upgrade selection UI |
| *Coming soon* | Inspector — ScriptableObject upgrade assets |

To add screenshots locally, place images under `docs/screenshots/` and reference them here:

```markdown
![Gameplay](docs/screenshots/gameplay.png)
```

---

## License

This project is licensed under the **MIT License**. See [LICENSE](LICENSE) for the full text.

Copyright (c) 2026 Білоус Ілля

---

# RogueLoopKit (Українська)

Модульний стартовий набір мобільного roguelike для Unity 6. RogueLoopKit дає інді-командам продакшен-орієнтовану основу: розв’язані ігрові системи, прогресія на даних і налаштування під мобільні платформи, які можна розширювати без переписування ядра геймплею.

---

## Можливості

- **Архітектура під мобільні** — Ввід під дотик, економні патерни оновлення та масштабований потік сцен для збірок iOS і Android.
- **Модульні ігрові системи** — Слабо зв’язані модулі з чіткими межами: увімкнення, заміна або розширення систем незалежно одна від одної.
- **ШІ ворогів** — Складова поведінка ворогів для хвильового бою та темпу roguelike.
- **Система навичок** — Виконання навичок у рантаймі з кулдаунами, хуками наведення та інтеграцією з VFX і UI.
- **Система покращень** — Хуки прогресії в межах забігу та мета-прогресії для нагородних циклів roguelike.
- **UI-фреймворк** — Переиспользувані екрани, віджети HUD і UI на подіях, прив’язаний до стану гри.
- **Хвильовий спавн** — Налаштовувані хвилі, точки спавну, темп і масштабування складності.
- **Покращення на ScriptableObject** — Ассети даних для дизайнерів: стати, перки та таблиці луту без змін коду.

---

## Технологічний стек

| Технологія | Призначення |
|------------|-------------|
| Unity 6 | Редактор і рантайм (перевірено на 6000.2.x) |
| URP 2D | 2D-конвеєр рендерингу |
| C# | Геймплей і код фреймворку |
| ScriptableObjects | Покращення, хвилі, навички та баланс |

Додаткові пакети в шаблоні: **Input System**, **UGUI**, **2D Animation** та **Timeline**.

---

## Структура папок

Проєкт Unity знаходиться в `My project/`. Набір організований навколо кореневої папки простору імен у `Assets`:

```
rogue-loop-kit/
├── LICENSE
├── README.md
└── My project/
    ├── Assets/
    │   ├── RogueLoopKit/
    │   │   ├── Core/           # Ігровий цикл, події, bootstrap
    │   │   ├── Player/         # Рух, стати, отримання урону
    │   │   ├── Enemies/        # Сутності ворогів, здоров’я, лут
    │   │   ├── AI/             # Поведінка, наведення, стани
    │   │   ├── Skills/         # Визначення навичок, виконання, кулдауни
    │   │   ├── Upgrades/       # Застосування покращень, модифікатори забігу
    │   │   ├── Spawning/       # Спавнер хвиль, точки, пулінг
    │   │   ├── UI/             # HUD, меню, екрани вибору покращень
    │   │   └── Data/           # Ассети ScriptableObject
    │   ├── Scenes/             # Bootstrap, геймплей, тестові сцени
    │   └── Settings/           # URP, рендерер, налаштування
    ├── Packages/
    └── ProjectSettings/
```

Модулі `RogueLoopKit/` додаються поступово в міру розвитку набору. Сцени та налаштування URP уже є з шаблону Unity 6 2D (URP).

---

## Встановлення

### Вимоги

- [Unity 6](https://unity.com/download) (рекомендовано 6000.2.x або новіше)
- Unity Hub (за бажанням)
- Git

### Клонування та відкриття

1. Клонуйте репозиторій:

   ```bash
   git clone https://github.com/<your-org>/rogue-loop-kit.git
   cd rogue-loop-kit
   ```

2. Відкрийте проєкт у Unity Hub:
   - **Add** → виберіть папку `My project` у клонованому репозиторії.
   - При першому відкритті Unity імпортує пакети з `Packages/manifest.json`.

3. Відкрийте зразкову сцену:
   - `Assets/Scenes/SampleScene.unity`

4. Налаштуйте мобільну платформу (за потреби):
   - **File → Build Profiles** (або **Build Settings**)
   - Оберіть **Android** або **iOS**
   - Налаштуйте **Player Settings** (орієнтація, safe area, ввід) під свою гру.

### Використання як старт у наявному проєкті

Скопіюйте папку `Assets/RogueLoopKit/` (коли з’явиться) у свій Unity 6 URP 2D проєкт. Переконайтеся, що через Package Manager встановлені **Input System** та **Universal RP**, потім підключіть bootstrap-сцену з `Assets/Scenes/`.

---

## Дорожня карта

| Фаза | Фокус | Статус |
|------|--------|--------|
| 0 | Шаблон Unity 6 URP 2D, структура репозиторію | В процесі |
| 1 | Ядро циклу, події, контролер гравця | Заплановано |
| 2 | ШІ ворогів і хвильовий спавн | Заплановано |
| 3 | Навички та покращення на ScriptableObject | Заплановано |
| 4 | UI-фреймворк і вибір покращень | Заплановано |
| 5 | Мобільна поліровка, пулінг, вертикальний зріз | Заплановано |
| 6 | Документація, пакет зразкового контенту | Заплановано |

Вітаються issue та внески в міру появи модулів.

---

## Скріншоти

Скріншоти будуть додані після завершення зразкового вертикального зрізу.

| Скріншот | Опис |
|----------|------|
| *Незабаром* | Геймплей — бій і цикл хвиль |
| *Незабаром* | UI вибору покращень |
| *Незабаром* | Інспектор — ассети покращень ScriptableObject |

Щоб додати скріншоти локально, покладіть зображення в `docs/screenshots/` і посилайтеся на них тут:

```markdown
![Gameplay](docs/screenshots/gameplay.png)
```

---

## Ліцензія

Проєкт поширюється за ліцензією **MIT**. Повний текст — у файлі [LICENSE](LICENSE).

Copyright (c) 2026 Білоус Ілля
