Fake Xrm Easy: TDD for Dynamics CRM and Dynamics 365 (or now Common Data Service for Apps) made simple
=================================================================================

## Support 

We believe in <b>sustainable</b> Open Source. The software is MIT licensed and provided to you for free but we encourage you (and by you, we mean the whole community) to extend it / improve it by yourselves, of course, with help from us. 

In programming terms: 

    Free Open Source !== Free Support. 

If you're a business entity who delivers solutions on top of the Power Platform and are using this project already, you can help make OSS sustainable while getting more visibility by becoming a sponsor. Please [reach out to me](jordi@dynamicsvalue.com) for sponsorship enquiries and to contribute and give back to this project.  

If you're an individual, feel free to check the Sponsorship tiers, any help is welcome and greatly appreciated.

For contributing, please see section below.
## Contributing (go to the original repo [jordimontana82/fake-xrm-easy](https://github.com/jordimontana82/fake-xrm-easy/))
Please consider the below guidelines for contributing to the project:

* Priority: Given the overwhelming number of issues and pull requests, we'll review Pull Requests first, then any outstanding issues. We encourage you to resolve / extend issues by yourselves, as a community, and we'll prioritise those first because we know (as mantainers) the effort it takes. 

    Please do [fork](https://github.com/jordimontana82/fake-xrm-easy/fork) the project and submit a [pull request](https://github.com/jordimontana82/fake-xrm-easy/pulls)
    
    We'll thank you forever and ever. 

    If you don't know how to resolve something or are not familiar with pull requests, don't worry, raise the issue anyway. Those will be revised next.

* When raising an issue:

    * <u>**Please provide a sample unit test**</u> to reproduce any issues detected where possible. This will speed up the resolution.
    * Attach all generated early bound typed entities required (if you're using early bound).

* **If you're using the framework, please do [Star](https://github.com/jordimontana82/fake-xrm-easy/star) the project**, it'll give more visibility to the wider community to keep extending and improving it.



## Roadmap

*  TODO: We're working on a v2.x of this package which targets .net core. That new version has been developed for the last couple of months, and we're VERY close to make it public. In the meantime, PRs and issues will be on hold for the time being to keep track of "where we are" in order to be merged into both versions 1.x and 2.x. [More info here](https://github.com/jordimontana82/fake-xrm-easy/issues/504)

*  TODO:  Add support for date operators. See `ConditionOperator` implementation status [here](https://github.com/jordimontana82/fake-xrm-easy/blob/master/FakeXrmEasy.Tests.Shared/FakeContextTests/FetchXml/ConditionOperatorTests.cs#L19-L110). Feel free to add missing ones!
*  TODO: Implement remaining CRM messages. To know which ones have been implemented so far, see `FakeMessageExecutor` implementation status [here](https://github.com/jordimontana82/fake-xrm-easy/tree/master/FakeXrmEasy.Shared/FakeMessageExecutors).
*  TODO: Increase test coverage.
*  **NEW!** I'm planning a 2.x version, this version will contain all the major improvements I always thought of adding but that will introduce considerable breaking changes. If you want to join a private preview list, let me know.



## Tests disappeared?

Try deleting anything under the VS test explorer cache: `%Temp%\VisualStudioTestExplorerExtensions`

