namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Scanner : java.lang.Object, Iterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Scanner()
		{
			InitJNI();
		}
		internal Scanner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString26519;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._toString26519)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._toString26519)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasNext26520;
		public bool hasNext(java.util.regex.Pattern arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNext26520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNext26520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNext26521;
		public bool hasNext(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNext26521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNext26521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNext26522;
		public bool hasNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNext26522);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNext26522);
		}
		internal static global::MonoJavaBridge.MethodId _next26523;
		public global::java.lang.String next(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._next26523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._next26523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _next26524;
		public global::java.lang.Object next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._next26524)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._next26524)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _next26525;
		public global::java.lang.String next(java.util.regex.Pattern arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._next26525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._next26525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _remove26526;
		public void remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Scanner._remove26526);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._remove26526);
		}
		internal static global::MonoJavaBridge.MethodId _close26527;
		public void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Scanner._close26527);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._close26527);
		}
		internal static global::MonoJavaBridge.MethodId _reset26528;
		public global::java.util.Scanner reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._reset26528)) as java.util.Scanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._reset26528)) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _nextDouble26529;
		public double nextDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.util.Scanner._nextDouble26529);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextDouble26529);
		}
		internal static global::MonoJavaBridge.MethodId _nextInt26530;
		public int nextInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Scanner._nextInt26530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextInt26530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextInt26531;
		public int nextInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Scanner._nextInt26531);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextInt26531);
		}
		internal static global::MonoJavaBridge.MethodId _nextLong26532;
		public long nextLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.Scanner._nextLong26532);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextLong26532);
		}
		internal static global::MonoJavaBridge.MethodId _nextLong26533;
		public long nextLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.Scanner._nextLong26533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextLong26533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skip26534;
		public global::java.util.Scanner skip(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._skip26534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._skip26534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _skip26535;
		public global::java.util.Scanner skip(java.util.regex.Pattern arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._skip26535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._skip26535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _locale26536;
		public global::java.util.Locale locale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._locale26536)) as java.util.Locale;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._locale26536)) as java.util.Locale;
		}
		internal static global::MonoJavaBridge.MethodId _match26537;
		public global::java.util.regex.MatchResult match() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._match26537)) as java.util.regex.MatchResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._match26537)) as java.util.regex.MatchResult;
		}
		internal static global::MonoJavaBridge.MethodId _nextBoolean26538;
		public bool nextBoolean() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._nextBoolean26538);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextBoolean26538);
		}
		internal static global::MonoJavaBridge.MethodId _nextFloat26539;
		public float nextFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.util.Scanner._nextFloat26539);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextFloat26539);
		}
		internal static global::MonoJavaBridge.MethodId _delimiter26540;
		public global::java.util.regex.Pattern delimiter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._delimiter26540)) as java.util.regex.Pattern;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._delimiter26540)) as java.util.regex.Pattern;
		}
		internal static global::MonoJavaBridge.MethodId _ioException26541;
		public global::java.io.IOException ioException() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._ioException26541)) as java.io.IOException;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._ioException26541)) as java.io.IOException;
		}
		internal static global::MonoJavaBridge.MethodId _radix26542;
		public int radix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Scanner._radix26542);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._radix26542);
		}
		internal static global::MonoJavaBridge.MethodId _useDelimiter26543;
		public global::java.util.Scanner useDelimiter(java.util.regex.Pattern arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._useDelimiter26543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._useDelimiter26543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _useDelimiter26544;
		public global::java.util.Scanner useDelimiter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._useDelimiter26544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._useDelimiter26544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _useLocale26545;
		public global::java.util.Scanner useLocale(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._useLocale26545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._useLocale26545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _useRadix26546;
		public global::java.util.Scanner useRadix(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._useRadix26546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._useRadix26546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _hasNextLine26547;
		public bool hasNextLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextLine26547);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextLine26547);
		}
		internal static global::MonoJavaBridge.MethodId _nextLine26548;
		public global::java.lang.String nextLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._nextLine26548)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextLine26548)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _findInLine26549;
		public global::java.lang.String findInLine(java.util.regex.Pattern arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._findInLine26549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._findInLine26549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _findInLine26550;
		public global::java.lang.String findInLine(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._findInLine26550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._findInLine26550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _findWithinHorizon26551;
		public global::java.lang.String findWithinHorizon(java.util.regex.Pattern arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._findWithinHorizon26551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._findWithinHorizon26551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _findWithinHorizon26552;
		public global::java.lang.String findWithinHorizon(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._findWithinHorizon26552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._findWithinHorizon26552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasNextBoolean26553;
		public bool hasNextBoolean() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextBoolean26553);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextBoolean26553);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextByte26554;
		public bool hasNextByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextByte26554);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextByte26554);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextByte26555;
		public bool hasNextByte(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextByte26555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextByte26555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextByte26556;
		public byte nextByte(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.util.Scanner._nextByte26556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextByte26556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextByte26557;
		public byte nextByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.util.Scanner._nextByte26557);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextByte26557);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextShort26558;
		public bool hasNextShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextShort26558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextShort26558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNextShort26559;
		public bool hasNextShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextShort26559);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextShort26559);
		}
		internal static global::MonoJavaBridge.MethodId _nextShort26560;
		public short nextShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.util.Scanner._nextShort26560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextShort26560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextShort26561;
		public short nextShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.util.Scanner._nextShort26561);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextShort26561);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextInt26562;
		public bool hasNextInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextInt26562);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextInt26562);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextInt26563;
		public bool hasNextInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextInt26563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextInt26563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNextLong26564;
		public bool hasNextLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextLong26564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextLong26564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNextLong26565;
		public bool hasNextLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextLong26565);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextLong26565);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextFloat26566;
		public bool hasNextFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextFloat26566);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextFloat26566);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextDouble26567;
		public bool hasNextDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextDouble26567);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextDouble26567);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextBigInteger26568;
		public bool hasNextBigInteger() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextBigInteger26568);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextBigInteger26568);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextBigInteger26569;
		public bool hasNextBigInteger(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextBigInteger26569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextBigInteger26569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextBigInteger26570;
		public global::java.math.BigInteger nextBigInteger(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._nextBigInteger26570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextBigInteger26570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _nextBigInteger26571;
		public global::java.math.BigInteger nextBigInteger() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._nextBigInteger26571)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextBigInteger26571)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _hasNextBigDecimal26572;
		public bool hasNextBigDecimal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextBigDecimal26572);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextBigDecimal26572);
		}
		internal static global::MonoJavaBridge.MethodId _nextBigDecimal26573;
		public global::java.math.BigDecimal nextBigDecimal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._nextBigDecimal26573)) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextBigDecimal26573)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26574;
		public Scanner(java.nio.channels.ReadableByteChannel arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26575;
		public Scanner(java.nio.channels.ReadableByteChannel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26576;
		public Scanner(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26577;
		public Scanner(java.io.File arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26578;
		public Scanner(java.io.File arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26579;
		public Scanner(java.io.InputStream arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26580;
		public Scanner(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26581;
		public Scanner(java.lang.Readable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Scanner.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Scanner"));
			global::java.util.Scanner._toString26519 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Scanner._hasNext26520 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNext", "(Ljava/util/regex/Pattern;)Z");
			global::java.util.Scanner._hasNext26521 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNext", "(Ljava/lang/String;)Z");
			global::java.util.Scanner._hasNext26522 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNext", "()Z");
			global::java.util.Scanner._next26523 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "next", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.Scanner._next26524 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "next", "()Ljava/lang/Object;");
			global::java.util.Scanner._next26525 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "next", "(Ljava/util/regex/Pattern;)Ljava/lang/String;");
			global::java.util.Scanner._remove26526 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "remove", "()V");
			global::java.util.Scanner._close26527 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "close", "()V");
			global::java.util.Scanner._reset26528 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "reset", "()Ljava/util/Scanner;");
			global::java.util.Scanner._nextDouble26529 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextDouble", "()D");
			global::java.util.Scanner._nextInt26530 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextInt", "(I)I");
			global::java.util.Scanner._nextInt26531 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextInt", "()I");
			global::java.util.Scanner._nextLong26532 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextLong", "()J");
			global::java.util.Scanner._nextLong26533 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextLong", "(I)J");
			global::java.util.Scanner._skip26534 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "skip", "(Ljava/lang/String;)Ljava/util/Scanner;");
			global::java.util.Scanner._skip26535 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "skip", "(Ljava/util/regex/Pattern;)Ljava/util/Scanner;");
			global::java.util.Scanner._locale26536 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "locale", "()Ljava/util/Locale;");
			global::java.util.Scanner._match26537 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "match", "()Ljava/util/regex/MatchResult;");
			global::java.util.Scanner._nextBoolean26538 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextBoolean", "()Z");
			global::java.util.Scanner._nextFloat26539 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextFloat", "()F");
			global::java.util.Scanner._delimiter26540 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "delimiter", "()Ljava/util/regex/Pattern;");
			global::java.util.Scanner._ioException26541 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "ioException", "()Ljava/io/IOException;");
			global::java.util.Scanner._radix26542 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "radix", "()I");
			global::java.util.Scanner._useDelimiter26543 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "useDelimiter", "(Ljava/util/regex/Pattern;)Ljava/util/Scanner;");
			global::java.util.Scanner._useDelimiter26544 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "useDelimiter", "(Ljava/lang/String;)Ljava/util/Scanner;");
			global::java.util.Scanner._useLocale26545 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "useLocale", "(Ljava/util/Locale;)Ljava/util/Scanner;");
			global::java.util.Scanner._useRadix26546 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "useRadix", "(I)Ljava/util/Scanner;");
			global::java.util.Scanner._hasNextLine26547 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextLine", "()Z");
			global::java.util.Scanner._nextLine26548 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextLine", "()Ljava/lang/String;");
			global::java.util.Scanner._findInLine26549 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "findInLine", "(Ljava/util/regex/Pattern;)Ljava/lang/String;");
			global::java.util.Scanner._findInLine26550 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "findInLine", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.Scanner._findWithinHorizon26551 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "findWithinHorizon", "(Ljava/util/regex/Pattern;I)Ljava/lang/String;");
			global::java.util.Scanner._findWithinHorizon26552 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "findWithinHorizon", "(Ljava/lang/String;I)Ljava/lang/String;");
			global::java.util.Scanner._hasNextBoolean26553 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextBoolean", "()Z");
			global::java.util.Scanner._hasNextByte26554 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextByte", "()Z");
			global::java.util.Scanner._hasNextByte26555 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextByte", "(I)Z");
			global::java.util.Scanner._nextByte26556 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextByte", "(I)B");
			global::java.util.Scanner._nextByte26557 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextByte", "()B");
			global::java.util.Scanner._hasNextShort26558 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextShort", "(I)Z");
			global::java.util.Scanner._hasNextShort26559 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextShort", "()Z");
			global::java.util.Scanner._nextShort26560 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextShort", "(I)S");
			global::java.util.Scanner._nextShort26561 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextShort", "()S");
			global::java.util.Scanner._hasNextInt26562 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextInt", "()Z");
			global::java.util.Scanner._hasNextInt26563 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextInt", "(I)Z");
			global::java.util.Scanner._hasNextLong26564 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextLong", "(I)Z");
			global::java.util.Scanner._hasNextLong26565 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextLong", "()Z");
			global::java.util.Scanner._hasNextFloat26566 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextFloat", "()Z");
			global::java.util.Scanner._hasNextDouble26567 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextDouble", "()Z");
			global::java.util.Scanner._hasNextBigInteger26568 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextBigInteger", "()Z");
			global::java.util.Scanner._hasNextBigInteger26569 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextBigInteger", "(I)Z");
			global::java.util.Scanner._nextBigInteger26570 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextBigInteger", "(I)Ljava/math/BigInteger;");
			global::java.util.Scanner._nextBigInteger26571 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextBigInteger", "()Ljava/math/BigInteger;");
			global::java.util.Scanner._hasNextBigDecimal26572 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextBigDecimal", "()Z");
			global::java.util.Scanner._nextBigDecimal26573 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextBigDecimal", "()Ljava/math/BigDecimal;");
			global::java.util.Scanner._Scanner26574 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/nio/channels/ReadableByteChannel;Ljava/lang/String;)V");
			global::java.util.Scanner._Scanner26575 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/nio/channels/ReadableByteChannel;)V");
			global::java.util.Scanner._Scanner26576 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.Scanner._Scanner26577 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::java.util.Scanner._Scanner26578 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.util.Scanner._Scanner26579 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/lang/String;)V");
			global::java.util.Scanner._Scanner26580 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::java.util.Scanner._Scanner26581 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/lang/Readable;)V");
		}
	}
}
