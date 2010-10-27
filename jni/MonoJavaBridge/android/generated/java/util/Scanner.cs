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
		internal static global::MonoJavaBridge.MethodId _toString26637;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._toString26637)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._toString26637)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasNext26638;
		public bool hasNext(java.util.regex.Pattern arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNext26638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNext26638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNext26639;
		public bool hasNext(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNext26639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNext26639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNext26640;
		public bool hasNext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNext26640);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNext26640);
		}
		internal static global::MonoJavaBridge.MethodId _next26641;
		public global::java.lang.String next(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._next26641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._next26641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _next26642;
		public global::java.lang.Object next()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._next26642)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._next26642)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _next26643;
		public global::java.lang.String next(java.util.regex.Pattern arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._next26643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._next26643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _remove26644;
		public void remove()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Scanner._remove26644);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._remove26644);
		}
		internal static global::MonoJavaBridge.MethodId _close26645;
		public void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Scanner._close26645);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._close26645);
		}
		internal static global::MonoJavaBridge.MethodId _reset26646;
		public global::java.util.Scanner reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Scanner>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._reset26646)) as java.util.Scanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Scanner>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._reset26646)) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _nextDouble26647;
		public double nextDouble()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.util.Scanner._nextDouble26647);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextDouble26647);
		}
		internal static global::MonoJavaBridge.MethodId _nextInt26648;
		public int nextInt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Scanner._nextInt26648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextInt26648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextInt26649;
		public int nextInt()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Scanner._nextInt26649);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextInt26649);
		}
		internal static global::MonoJavaBridge.MethodId _nextLong26650;
		public long nextLong()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.Scanner._nextLong26650);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextLong26650);
		}
		internal static global::MonoJavaBridge.MethodId _nextLong26651;
		public long nextLong(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.Scanner._nextLong26651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextLong26651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skip26652;
		public global::java.util.Scanner skip(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Scanner>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._skip26652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Scanner>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._skip26652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _skip26653;
		public global::java.util.Scanner skip(java.util.regex.Pattern arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Scanner>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._skip26653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Scanner>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._skip26653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _locale26654;
		public global::java.util.Locale locale()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._locale26654)) as java.util.Locale;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._locale26654)) as java.util.Locale;
		}
		internal static global::MonoJavaBridge.MethodId _match26655;
		public global::java.util.regex.MatchResult match()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._match26655)) as java.util.regex.MatchResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._match26655)) as java.util.regex.MatchResult;
		}
		internal static global::MonoJavaBridge.MethodId _nextBoolean26656;
		public bool nextBoolean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._nextBoolean26656);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextBoolean26656);
		}
		internal static global::MonoJavaBridge.MethodId _nextFloat26657;
		public float nextFloat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.util.Scanner._nextFloat26657);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextFloat26657);
		}
		internal static global::MonoJavaBridge.MethodId _delimiter26658;
		public global::java.util.regex.Pattern delimiter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Pattern>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._delimiter26658)) as java.util.regex.Pattern;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Pattern>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._delimiter26658)) as java.util.regex.Pattern;
		}
		internal static global::MonoJavaBridge.MethodId _ioException26659;
		public global::java.io.IOException ioException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._ioException26659)) as java.io.IOException;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._ioException26659)) as java.io.IOException;
		}
		internal static global::MonoJavaBridge.MethodId _radix26660;
		public int radix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Scanner._radix26660);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._radix26660);
		}
		internal static global::MonoJavaBridge.MethodId _useDelimiter26661;
		public global::java.util.Scanner useDelimiter(java.util.regex.Pattern arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Scanner>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._useDelimiter26661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Scanner>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._useDelimiter26661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _useDelimiter26662;
		public global::java.util.Scanner useDelimiter(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Scanner>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._useDelimiter26662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Scanner>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._useDelimiter26662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _useLocale26663;
		public global::java.util.Scanner useLocale(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Scanner>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._useLocale26663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Scanner>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._useLocale26663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _useRadix26664;
		public global::java.util.Scanner useRadix(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Scanner>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._useRadix26664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Scanner>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._useRadix26664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _hasNextLine26665;
		public bool hasNextLine()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextLine26665);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextLine26665);
		}
		internal static global::MonoJavaBridge.MethodId _nextLine26666;
		public global::java.lang.String nextLine()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._nextLine26666)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextLine26666)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _findInLine26667;
		public global::java.lang.String findInLine(java.util.regex.Pattern arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._findInLine26667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._findInLine26667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _findInLine26668;
		public global::java.lang.String findInLine(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._findInLine26668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._findInLine26668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _findWithinHorizon26669;
		public global::java.lang.String findWithinHorizon(java.util.regex.Pattern arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._findWithinHorizon26669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._findWithinHorizon26669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _findWithinHorizon26670;
		public global::java.lang.String findWithinHorizon(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._findWithinHorizon26670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._findWithinHorizon26670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasNextBoolean26671;
		public bool hasNextBoolean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextBoolean26671);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextBoolean26671);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextByte26672;
		public bool hasNextByte()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextByte26672);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextByte26672);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextByte26673;
		public bool hasNextByte(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextByte26673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextByte26673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextByte26674;
		public byte nextByte(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.util.Scanner._nextByte26674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextByte26674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextByte26675;
		public byte nextByte()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.util.Scanner._nextByte26675);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextByte26675);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextShort26676;
		public bool hasNextShort(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextShort26676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextShort26676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNextShort26677;
		public bool hasNextShort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextShort26677);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextShort26677);
		}
		internal static global::MonoJavaBridge.MethodId _nextShort26678;
		public short nextShort(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.util.Scanner._nextShort26678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextShort26678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextShort26679;
		public short nextShort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.util.Scanner._nextShort26679);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextShort26679);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextInt26680;
		public bool hasNextInt()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextInt26680);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextInt26680);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextInt26681;
		public bool hasNextInt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextInt26681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextInt26681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNextLong26682;
		public bool hasNextLong(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextLong26682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextLong26682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNextLong26683;
		public bool hasNextLong()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextLong26683);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextLong26683);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextFloat26684;
		public bool hasNextFloat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextFloat26684);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextFloat26684);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextDouble26685;
		public bool hasNextDouble()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextDouble26685);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextDouble26685);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextBigInteger26686;
		public bool hasNextBigInteger()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextBigInteger26686);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextBigInteger26686);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextBigInteger26687;
		public bool hasNextBigInteger(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextBigInteger26687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextBigInteger26687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextBigInteger26688;
		public global::java.math.BigInteger nextBigInteger(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._nextBigInteger26688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextBigInteger26688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _nextBigInteger26689;
		public global::java.math.BigInteger nextBigInteger()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._nextBigInteger26689)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextBigInteger26689)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _hasNextBigDecimal26690;
		public bool hasNextBigDecimal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Scanner._hasNextBigDecimal26690);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._hasNextBigDecimal26690);
		}
		internal static global::MonoJavaBridge.MethodId _nextBigDecimal26691;
		public global::java.math.BigDecimal nextBigDecimal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Scanner._nextBigDecimal26691)) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Scanner.staticClass, global::java.util.Scanner._nextBigDecimal26691)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26692;
		public Scanner(java.nio.channels.ReadableByteChannel arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26693;
		public Scanner(java.nio.channels.ReadableByteChannel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26694;
		public Scanner(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26695;
		public Scanner(java.io.File arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26696;
		public Scanner(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26697;
		public Scanner(java.io.InputStream arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26698;
		public Scanner(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26699;
		public Scanner(java.lang.Readable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Scanner.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Scanner"));
			global::java.util.Scanner._toString26637 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Scanner._hasNext26638 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNext", "(Ljava/util/regex/Pattern;)Z");
			global::java.util.Scanner._hasNext26639 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNext", "(Ljava/lang/String;)Z");
			global::java.util.Scanner._hasNext26640 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNext", "()Z");
			global::java.util.Scanner._next26641 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "next", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.Scanner._next26642 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "next", "()Ljava/lang/Object;");
			global::java.util.Scanner._next26643 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "next", "(Ljava/util/regex/Pattern;)Ljava/lang/String;");
			global::java.util.Scanner._remove26644 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "remove", "()V");
			global::java.util.Scanner._close26645 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "close", "()V");
			global::java.util.Scanner._reset26646 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "reset", "()Ljava/util/Scanner;");
			global::java.util.Scanner._nextDouble26647 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextDouble", "()D");
			global::java.util.Scanner._nextInt26648 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextInt", "(I)I");
			global::java.util.Scanner._nextInt26649 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextInt", "()I");
			global::java.util.Scanner._nextLong26650 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextLong", "()J");
			global::java.util.Scanner._nextLong26651 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextLong", "(I)J");
			global::java.util.Scanner._skip26652 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "skip", "(Ljava/lang/String;)Ljava/util/Scanner;");
			global::java.util.Scanner._skip26653 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "skip", "(Ljava/util/regex/Pattern;)Ljava/util/Scanner;");
			global::java.util.Scanner._locale26654 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "locale", "()Ljava/util/Locale;");
			global::java.util.Scanner._match26655 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "match", "()Ljava/util/regex/MatchResult;");
			global::java.util.Scanner._nextBoolean26656 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextBoolean", "()Z");
			global::java.util.Scanner._nextFloat26657 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextFloat", "()F");
			global::java.util.Scanner._delimiter26658 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "delimiter", "()Ljava/util/regex/Pattern;");
			global::java.util.Scanner._ioException26659 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "ioException", "()Ljava/io/IOException;");
			global::java.util.Scanner._radix26660 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "radix", "()I");
			global::java.util.Scanner._useDelimiter26661 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "useDelimiter", "(Ljava/util/regex/Pattern;)Ljava/util/Scanner;");
			global::java.util.Scanner._useDelimiter26662 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "useDelimiter", "(Ljava/lang/String;)Ljava/util/Scanner;");
			global::java.util.Scanner._useLocale26663 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "useLocale", "(Ljava/util/Locale;)Ljava/util/Scanner;");
			global::java.util.Scanner._useRadix26664 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "useRadix", "(I)Ljava/util/Scanner;");
			global::java.util.Scanner._hasNextLine26665 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextLine", "()Z");
			global::java.util.Scanner._nextLine26666 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextLine", "()Ljava/lang/String;");
			global::java.util.Scanner._findInLine26667 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "findInLine", "(Ljava/util/regex/Pattern;)Ljava/lang/String;");
			global::java.util.Scanner._findInLine26668 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "findInLine", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.Scanner._findWithinHorizon26669 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "findWithinHorizon", "(Ljava/util/regex/Pattern;I)Ljava/lang/String;");
			global::java.util.Scanner._findWithinHorizon26670 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "findWithinHorizon", "(Ljava/lang/String;I)Ljava/lang/String;");
			global::java.util.Scanner._hasNextBoolean26671 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextBoolean", "()Z");
			global::java.util.Scanner._hasNextByte26672 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextByte", "()Z");
			global::java.util.Scanner._hasNextByte26673 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextByte", "(I)Z");
			global::java.util.Scanner._nextByte26674 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextByte", "(I)B");
			global::java.util.Scanner._nextByte26675 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextByte", "()B");
			global::java.util.Scanner._hasNextShort26676 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextShort", "(I)Z");
			global::java.util.Scanner._hasNextShort26677 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextShort", "()Z");
			global::java.util.Scanner._nextShort26678 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextShort", "(I)S");
			global::java.util.Scanner._nextShort26679 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextShort", "()S");
			global::java.util.Scanner._hasNextInt26680 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextInt", "()Z");
			global::java.util.Scanner._hasNextInt26681 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextInt", "(I)Z");
			global::java.util.Scanner._hasNextLong26682 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextLong", "(I)Z");
			global::java.util.Scanner._hasNextLong26683 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextLong", "()Z");
			global::java.util.Scanner._hasNextFloat26684 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextFloat", "()Z");
			global::java.util.Scanner._hasNextDouble26685 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextDouble", "()Z");
			global::java.util.Scanner._hasNextBigInteger26686 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextBigInteger", "()Z");
			global::java.util.Scanner._hasNextBigInteger26687 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextBigInteger", "(I)Z");
			global::java.util.Scanner._nextBigInteger26688 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextBigInteger", "(I)Ljava/math/BigInteger;");
			global::java.util.Scanner._nextBigInteger26689 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextBigInteger", "()Ljava/math/BigInteger;");
			global::java.util.Scanner._hasNextBigDecimal26690 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "hasNextBigDecimal", "()Z");
			global::java.util.Scanner._nextBigDecimal26691 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "nextBigDecimal", "()Ljava/math/BigDecimal;");
			global::java.util.Scanner._Scanner26692 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/nio/channels/ReadableByteChannel;Ljava/lang/String;)V");
			global::java.util.Scanner._Scanner26693 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/nio/channels/ReadableByteChannel;)V");
			global::java.util.Scanner._Scanner26694 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.Scanner._Scanner26695 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::java.util.Scanner._Scanner26696 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.util.Scanner._Scanner26697 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/lang/String;)V");
			global::java.util.Scanner._Scanner26698 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::java.util.Scanner._Scanner26699 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/lang/Readable;)V");
		}
	}
}
