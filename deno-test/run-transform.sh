#! /usr/bin/env bash
set -uvx
set -e
cd "$(dirname "$0")"
cwd=`pwd`
ts=`date "+%Y.%m%d.%H%M.%S"`

cp https-cdn.jsdelivr.net-npm-@babel-standalone@7.28.6-babel.js babel-standalone.mjs
echo "const Babel = globalThis.Babel;" >> babel-standalone.mjs
echo "export { Babel };" >> babel-standalone.mjs
./transform.mjs
