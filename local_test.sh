#!/usr/bin/env sh

set -x

export UNITY_EXECUTABLE=${UNITY_EXECUTABLE:-"/Applications/Unity/Hub/Editor/2019.3.0a8/Unity.app/Contents/MacOS/Unity"}

TEST_PLATFORM=editmode ./.CI/test.sh