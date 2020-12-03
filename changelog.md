# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [2.0.0](https://github.com/unity-game-framework/ugf-description/releases/tag/2.0.0) - 2020-12-03  

### Release Notes

- [Milestone](https://github.com/unity-game-framework/ugf-description/milestone/4?closed=1)  
    

### Changed

- Rework descriptions ([#10](https://github.com/unity-game-framework/ugf-description/pull/10))  
    - Add `IDescriptionBuilder` interface and default implementations to use with classes, assets and components.
    - Add `IDescribed` and `IDescribed<T>` interfaces and default implementation `DescribedBase<T>` class.
    - Add `IDescribedBuilder` interface and default implementations to use with classes, assets and components.
    - Add `DescribedWithDescriptionBuilder` and other classes to implement compounded builder of `IDescribed` and `IDescription`, and default implementations to use with classes, assets and components.
    - Remove legacy descriptions.
- Update to Unity 2020.2 ([#9](https://github.com/unity-game-framework/ugf-description/pull/9))

## [1.0.1-preview](https://github.com/unity-game-framework/ugf-description/releases/tag/1.0.1-preview) - 2019-10-05  

- [Commits](https://github.com/unity-game-framework/ugf-description/compare/1.0.0-preview.1...1.0.1-preview)
- [Milestone](https://github.com/unity-game-framework/ugf-description/milestone/3?closed=1)

### Fixed
- `DescriptionAssetEditor`: allow `OnEnabled` to override.

## [1.0.0-preview.1](https://github.com/unity-game-framework/ugf-description/releases/tag/1.0.0-preview.1) - 2019-09-15  

- [Commits](https://github.com/unity-game-framework/ugf-description/compare/1.0.0-preview...1.0.0-preview.1)
- [Milestone](https://github.com/unity-game-framework/ugf-description/milestone/2?closed=1)

### Added
- `DescriptionAsset` generic variant of `GetDescription`.

### Changed
- Update to Unity 2019.2.

### Fixed
- `DescriptionAssetEditor` drawing description data.

## [1.0.0-preview](https://github.com/unity-game-framework/ugf-description/releases/tag/1.0.0-preview) - 2019-07-23  

- [Commits](https://github.com/unity-game-framework/ugf-description/compare/abea18a...1.0.0-preview)
- [Milestone](https://github.com/unity-game-framework/ugf-description/milestone/1?closed=1)

### Added
- This is a initial release.


