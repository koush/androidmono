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
		internal static global::MonoJavaBridge.MethodId _toString20694;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._toString20694)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._toString20694)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasNext20695;
		public bool hasNext(java.util.regex.Pattern arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNext20695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNext20695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNext20696;
		public bool hasNext(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNext20696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNext20696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNext20697;
		public bool hasNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNext20697);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNext20697);
		}
		internal static global::MonoJavaBridge.MethodId _next20698;
		public global::java.lang.String next(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._next20698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._next20698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _next20699;
		public global::java.lang.Object next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._next20699)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._next20699)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _next20700;
		public global::java.lang.String next(java.util.regex.Pattern arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._next20700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._next20700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _remove20701;
		public void remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Scanner._remove20701);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._remove20701);
		}
		internal static global::MonoJavaBridge.MethodId _close20702;
		public void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Scanner._close20702);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._close20702);
		}
		internal static global::MonoJavaBridge.MethodId _reset20703;
		public global::java.util.Scanner reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._reset20703)) as java.util.Scanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._reset20703)) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _nextDouble20704;
		public double nextDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.util.Scanner._nextDouble20704);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextDouble20704);
		}
		internal static global::MonoJavaBridge.MethodId _nextInt20705;
		public int nextInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Scanner._nextInt20705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextInt20705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextInt20706;
		public int nextInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Scanner._nextInt20706);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextInt20706);
		}
		internal static global::MonoJavaBridge.MethodId _nextLong20707;
		public long nextLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.Scanner._nextLong20707);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextLong20707);
		}
		internal static global::MonoJavaBridge.MethodId _nextLong20708;
		public long nextLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.Scanner._nextLong20708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextLong20708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skip20709;
		public global::java.util.Scanner skip(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._skip20709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._skip20709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _skip20710;
		public global::java.util.Scanner skip(java.util.regex.Pattern arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._skip20710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._skip20710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _locale20711;
		public global::java.util.Locale locale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._locale20711)) as java.util.Locale;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._locale20711)) as java.util.Locale;
		}
		internal static global::MonoJavaBridge.MethodId _match20712;
		public global::java.util.regex.MatchResult match() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._match20712)) as java.util.regex.MatchResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._match20712)) as java.util.regex.MatchResult;
		}
		internal static global::MonoJavaBridge.MethodId _nextBoolean20713;
		public bool nextBoolean() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._nextBoolean20713);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextBoolean20713);
		}
		internal static global::MonoJavaBridge.MethodId _nextFloat20714;
		public float nextFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.util.Scanner._nextFloat20714);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextFloat20714);
		}
		internal static global::MonoJavaBridge.MethodId _delimiter20715;
		public global::java.util.regex.Pattern delimiter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._delimiter20715)) as java.util.regex.Pattern;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._delimiter20715)) as java.util.regex.Pattern;
		}
		internal static global::MonoJavaBridge.MethodId _ioException20716;
		public global::java.io.IOException ioException() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._ioException20716)) as java.io.IOException;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._ioException20716)) as java.io.IOException;
		}
		internal static global::MonoJavaBridge.MethodId _radix20717;
		public int radix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Scanner._radix20717);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._radix20717);
		}
		internal static global::MonoJavaBridge.MethodId _useDelimiter20718;
		public global::java.util.Scanner useDelimiter(java.util.regex.Pattern arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._useDelimiter20718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._useDelimiter20718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _useDelimiter20719;
		public global::java.util.Scanner useDelimiter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._useDelimiter20719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._useDelimiter20719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _useLocale20720;
		public global::java.util.Scanner useLocale(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._useLocale20720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._useLocale20720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _useRadix20721;
		public global::java.util.Scanner useRadix(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._useRadix20721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._useRadix20721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _hasNextLine20722;
		public bool hasNextLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextLine20722);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextLine20722);
		}
		internal static global::MonoJavaBridge.MethodId _nextLine20723;
		public global::java.lang.String nextLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._nextLine20723)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextLine20723)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _findInLine20724;
		public global::java.lang.String findInLine(java.util.regex.Pattern arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._findInLine20724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._findInLine20724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _findInLine20725;
		public global::java.lang.String findInLine(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._findInLine20725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._findInLine20725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _findWithinHorizon20726;
		public global::java.lang.String findWithinHorizon(java.util.regex.Pattern arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._findWithinHorizon20726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._findWithinHorizon20726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _findWithinHorizon20727;
		public global::java.lang.String findWithinHorizon(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._findWithinHorizon20727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._findWithinHorizon20727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasNextBoolean20728;
		public bool hasNextBoolean() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextBoolean20728);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextBoolean20728);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextByte20729;
		public bool hasNextByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextByte20729);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextByte20729);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextByte20730;
		public bool hasNextByte(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextByte20730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextByte20730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextByte20731;
		public byte nextByte(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.util.Scanner._nextByte20731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextByte20731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextByte20732;
		public byte nextByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.util.Scanner._nextByte20732);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextByte20732);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextShort20733;
		public bool hasNextShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextShort20733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextShort20733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNextShort20734;
		public bool hasNextShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextShort20734);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextShort20734);
		}
		internal static global::MonoJavaBridge.MethodId _nextShort20735;
		public short nextShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.util.Scanner._nextShort20735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextShort20735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextShort20736;
		public short nextShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.util.Scanner._nextShort20736);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextShort20736);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextInt20737;
		public bool hasNextInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextInt20737);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextInt20737);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextInt20738;
		public bool hasNextInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextInt20738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextInt20738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNextLong20739;
		public bool hasNextLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextLong20739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextLong20739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNextLong20740;
		public bool hasNextLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextLong20740);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextLong20740);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextFloat20741;
		public bool hasNextFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextFloat20741);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextFloat20741);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextDouble20742;
		public bool hasNextDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextDouble20742);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextDouble20742);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextBigInteger20743;
		public bool hasNextBigInteger() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextBigInteger20743);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextBigInteger20743);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextBigInteger20744;
		public bool hasNextBigInteger(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextBigInteger20744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextBigInteger20744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextBigInteger20745;
		public global::java.math.BigInteger nextBigInteger(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._nextBigInteger20745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextBigInteger20745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _nextBigInteger20746;
		public global::java.math.BigInteger nextBigInteger() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._nextBigInteger20746)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextBigInteger20746)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _hasNextBigDecimal20747;
		public bool hasNextBigDecimal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextBigDecimal20747);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextBigDecimal20747);
		}
		internal static global::MonoJavaBridge.MethodId _nextBigDecimal20748;
		public global::java.math.BigDecimal nextBigDecimal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._nextBigDecimal20748)) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextBigDecimal20748)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _Scanner20749;
		public Scanner(java.nio.channels.ReadableByteChannel arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner20749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner20750;
		public Scanner(java.nio.channels.ReadableByteChannel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner20750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner20751;
		public Scanner(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner20751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner20752;
		public Scanner(java.io.File arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner20752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner20753;
		public Scanner(java.io.File arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner20753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner20754;
		public Scanner(java.io.InputStream arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner20754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner20755;
		public Scanner(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner20755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner20756;
		public Scanner(java.lang.Readable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner20756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Scanner.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Scanner"));
			global::java.util.Scanner._toString20694 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Scanner._hasNext20695 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNext", "(Ljava/util/regex/Pattern;)Z");
			global::java.util.Scanner._hasNext20696 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNext", "(Ljava/lang/String;)Z");
			global::java.util.Scanner._hasNext20697 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNext", "()Z");
			global::java.util.Scanner._next20698 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "next", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.Scanner._next20699 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "next", "()Ljava/lang/Object;");
			global::java.util.Scanner._next20700 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "next", "(Ljava/util/regex/Pattern;)Ljava/lang/String;");
			global::java.util.Scanner._remove20701 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "remove", "()V");
			global::java.util.Scanner._close20702 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "close", "()V");
			global::java.util.Scanner._reset20703 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "reset", "()Ljava/util/Scanner;");
			global::java.util.Scanner._nextDouble20704 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextDouble", "()D");
			global::java.util.Scanner._nextInt20705 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextInt", "(I)I");
			global::java.util.Scanner._nextInt20706 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextInt", "()I");
			global::java.util.Scanner._nextLong20707 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextLong", "()J");
			global::java.util.Scanner._nextLong20708 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextLong", "(I)J");
			global::java.util.Scanner._skip20709 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "skip", "(Ljava/lang/String;)Ljava/util/Scanner;");
			global::java.util.Scanner._skip20710 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "skip", "(Ljava/util/regex/Pattern;)Ljava/util/Scanner;");
			global::java.util.Scanner._locale20711 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "locale", "()Ljava/util/Locale;");
			global::java.util.Scanner._match20712 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "match", "()Ljava/util/regex/MatchResult;");
			global::java.util.Scanner._nextBoolean20713 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextBoolean", "()Z");
			global::java.util.Scanner._nextFloat20714 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextFloat", "()F");
			global::java.util.Scanner._delimiter20715 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "delimiter", "()Ljava/util/regex/Pattern;");
			global::java.util.Scanner._ioException20716 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "ioException", "()Ljava/io/IOException;");
			global::java.util.Scanner._radix20717 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "radix", "()I");
			global::java.util.Scanner._useDelimiter20718 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "useDelimiter", "(Ljava/util/regex/Pattern;)Ljava/util/Scanner;");
			global::java.util.Scanner._useDelimiter20719 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "useDelimiter", "(Ljava/lang/String;)Ljava/util/Scanner;");
			global::java.util.Scanner._useLocale20720 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "useLocale", "(Ljava/util/Locale;)Ljava/util/Scanner;");
			global::java.util.Scanner._useRadix20721 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "useRadix", "(I)Ljava/util/Scanner;");
			global::java.util.Scanner._hasNextLine20722 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextLine", "()Z");
			global::java.util.Scanner._nextLine20723 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextLine", "()Ljava/lang/String;");
			global::java.util.Scanner._findInLine20724 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "findInLine", "(Ljava/util/regex/Pattern;)Ljava/lang/String;");
			global::java.util.Scanner._findInLine20725 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "findInLine", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.Scanner._findWithinHorizon20726 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "findWithinHorizon", "(Ljava/util/regex/Pattern;I)Ljava/lang/String;");
			global::java.util.Scanner._findWithinHorizon20727 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "findWithinHorizon", "(Ljava/lang/String;I)Ljava/lang/String;");
			global::java.util.Scanner._hasNextBoolean20728 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextBoolean", "()Z");
			global::java.util.Scanner._hasNextByte20729 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextByte", "()Z");
			global::java.util.Scanner._hasNextByte20730 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextByte", "(I)Z");
			global::java.util.Scanner._nextByte20731 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextByte", "(I)B");
			global::java.util.Scanner._nextByte20732 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextByte", "()B");
			global::java.util.Scanner._hasNextShort20733 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextShort", "(I)Z");
			global::java.util.Scanner._hasNextShort20734 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextShort", "()Z");
			global::java.util.Scanner._nextShort20735 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextShort", "(I)S");
			global::java.util.Scanner._nextShort20736 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextShort", "()S");
			global::java.util.Scanner._hasNextInt20737 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextInt", "()Z");
			global::java.util.Scanner._hasNextInt20738 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextInt", "(I)Z");
			global::java.util.Scanner._hasNextLong20739 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextLong", "(I)Z");
			global::java.util.Scanner._hasNextLong20740 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextLong", "()Z");
			global::java.util.Scanner._hasNextFloat20741 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextFloat", "()Z");
			global::java.util.Scanner._hasNextDouble20742 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextDouble", "()Z");
			global::java.util.Scanner._hasNextBigInteger20743 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextBigInteger", "()Z");
			global::java.util.Scanner._hasNextBigInteger20744 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextBigInteger", "(I)Z");
			global::java.util.Scanner._nextBigInteger20745 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextBigInteger", "(I)Ljava/math/BigInteger;");
			global::java.util.Scanner._nextBigInteger20746 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextBigInteger", "()Ljava/math/BigInteger;");
			global::java.util.Scanner._hasNextBigDecimal20747 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextBigDecimal", "()Z");
			global::java.util.Scanner._nextBigDecimal20748 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextBigDecimal", "()Ljava/math/BigDecimal;");
			global::java.util.Scanner._Scanner20749 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/nio/channels/ReadableByteChannel;Ljava/lang/String;)V");
			global::java.util.Scanner._Scanner20750 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/nio/channels/ReadableByteChannel;)V");
			global::java.util.Scanner._Scanner20751 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.Scanner._Scanner20752 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::java.util.Scanner._Scanner20753 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.util.Scanner._Scanner20754 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/lang/String;)V");
			global::java.util.Scanner._Scanner20755 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::java.util.Scanner._Scanner20756 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/lang/Readable;)V");
		}
	}
}
