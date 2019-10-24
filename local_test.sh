#!/usr/bin/env sh

set -x

export UNITY_EXECUTABLE=${UNITY_EXECUTABLE:-"/opt/Unity-2018.3.11f1/"}

TEST_PLATFORM=editmode ./.CI/test.sh