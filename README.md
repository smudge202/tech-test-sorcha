# Technical Test for Speik

I haven't provided a UI. If you'd like me to throw together an un-tested console app quickly, drop me a [mail](mailto:smudge202@gmail.com).

The generator uses a cryptographic random number generator to ensure fairness and remove the possibility of guessing the random seed.

I've tested at component level (instead of unit) to save some time, which is my preferred style of testing.

## Long Running Tests

Due to the random nature of.. random, some of the tests can be long running. If your machine isn't quick or you don't want to wait, feel free to disable the `LONG_RUNNING_TESTS` compiler directive.
