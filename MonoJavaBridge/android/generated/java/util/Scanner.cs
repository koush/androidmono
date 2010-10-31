namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Scanner : java.lang.Object, Iterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Scanner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Scanner.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.Scanner._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public bool hasNext(java.util.regex.Pattern arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNext", "(Ljava/util/regex/Pattern;)Z", ref global::java.util.Scanner._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public bool hasNext(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNext", "(Ljava/lang/String;)Z", ref global::java.util.Scanner._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public bool hasNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNext", "()Z", ref global::java.util.Scanner._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::java.lang.String next(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Scanner.staticClass, "next", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.util.Scanner._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public global::java.lang.Object next()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Scanner.staticClass, "next", "()Ljava/lang/Object;", ref global::java.util.Scanner._m5) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public global::java.lang.String next(java.util.regex.Pattern arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Scanner.staticClass, "next", "(Ljava/util/regex/Pattern;)Ljava/lang/String;", ref global::java.util.Scanner._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public void remove()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Scanner.staticClass, "remove", "()V", ref global::java.util.Scanner._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Scanner.staticClass, "close", "()V", ref global::java.util.Scanner._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public global::java.util.Scanner reset()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Scanner>(this, global::java.util.Scanner.staticClass, "reset", "()Ljava/util/Scanner;", ref global::java.util.Scanner._m9) as java.util.Scanner;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public double nextDouble()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.util.Scanner.staticClass, "nextDouble", "()D", ref global::java.util.Scanner._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public int nextInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Scanner.staticClass, "nextInt", "(I)I", ref global::java.util.Scanner._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public int nextInt()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Scanner.staticClass, "nextInt", "()I", ref global::java.util.Scanner._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public long nextLong()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.Scanner.staticClass, "nextLong", "()J", ref global::java.util.Scanner._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public long nextLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.Scanner.staticClass, "nextLong", "(I)J", ref global::java.util.Scanner._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public global::java.util.Scanner skip(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Scanner>(this, global::java.util.Scanner.staticClass, "skip", "(Ljava/lang/String;)Ljava/util/Scanner;", ref global::java.util.Scanner._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Scanner;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public global::java.util.Scanner skip(java.util.regex.Pattern arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Scanner>(this, global::java.util.Scanner.staticClass, "skip", "(Ljava/util/regex/Pattern;)Ljava/util/Scanner;", ref global::java.util.Scanner._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Scanner;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public global::java.util.Locale locale()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Locale>(this, global::java.util.Scanner.staticClass, "locale", "()Ljava/util/Locale;", ref global::java.util.Scanner._m17) as java.util.Locale;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public global::java.util.regex.MatchResult match()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.regex.MatchResult>(this, global::java.util.Scanner.staticClass, "match", "()Ljava/util/regex/MatchResult;", ref global::java.util.Scanner._m18) as java.util.regex.MatchResult;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public bool nextBoolean()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "nextBoolean", "()Z", ref global::java.util.Scanner._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public float nextFloat()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.util.Scanner.staticClass, "nextFloat", "()F", ref global::java.util.Scanner._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public global::java.util.regex.Pattern delimiter()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.regex.Pattern>(this, global::java.util.Scanner.staticClass, "delimiter", "()Ljava/util/regex/Pattern;", ref global::java.util.Scanner._m21) as java.util.regex.Pattern;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public global::java.io.IOException ioException()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Scanner.staticClass, "ioException", "()Ljava/io/IOException;", ref global::java.util.Scanner._m22) as java.io.IOException;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public int radix()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Scanner.staticClass, "radix", "()I", ref global::java.util.Scanner._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public global::java.util.Scanner useDelimiter(java.util.regex.Pattern arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Scanner>(this, global::java.util.Scanner.staticClass, "useDelimiter", "(Ljava/util/regex/Pattern;)Ljava/util/Scanner;", ref global::java.util.Scanner._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Scanner;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public global::java.util.Scanner useDelimiter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Scanner>(this, global::java.util.Scanner.staticClass, "useDelimiter", "(Ljava/lang/String;)Ljava/util/Scanner;", ref global::java.util.Scanner._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Scanner;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public global::java.util.Scanner useLocale(java.util.Locale arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Scanner>(this, global::java.util.Scanner.staticClass, "useLocale", "(Ljava/util/Locale;)Ljava/util/Scanner;", ref global::java.util.Scanner._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Scanner;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public global::java.util.Scanner useRadix(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Scanner>(this, global::java.util.Scanner.staticClass, "useRadix", "(I)Ljava/util/Scanner;", ref global::java.util.Scanner._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Scanner;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public bool hasNextLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextLine", "()Z", ref global::java.util.Scanner._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public global::java.lang.String nextLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Scanner.staticClass, "nextLine", "()Ljava/lang/String;", ref global::java.util.Scanner._m29) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public global::java.lang.String findInLine(java.util.regex.Pattern arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Scanner.staticClass, "findInLine", "(Ljava/util/regex/Pattern;)Ljava/lang/String;", ref global::java.util.Scanner._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public global::java.lang.String findInLine(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Scanner.staticClass, "findInLine", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.util.Scanner._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public global::java.lang.String findWithinHorizon(java.util.regex.Pattern arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Scanner.staticClass, "findWithinHorizon", "(Ljava/util/regex/Pattern;I)Ljava/lang/String;", ref global::java.util.Scanner._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public global::java.lang.String findWithinHorizon(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Scanner.staticClass, "findWithinHorizon", "(Ljava/lang/String;I)Ljava/lang/String;", ref global::java.util.Scanner._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public bool hasNextBoolean()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextBoolean", "()Z", ref global::java.util.Scanner._m34);
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public bool hasNextByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextByte", "()Z", ref global::java.util.Scanner._m35);
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public bool hasNextByte(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextByte", "(I)Z", ref global::java.util.Scanner._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public byte nextByte(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.util.Scanner.staticClass, "nextByte", "(I)B", ref global::java.util.Scanner._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public byte nextByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.util.Scanner.staticClass, "nextByte", "()B", ref global::java.util.Scanner._m38);
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public bool hasNextShort(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextShort", "(I)Z", ref global::java.util.Scanner._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public bool hasNextShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextShort", "()Z", ref global::java.util.Scanner._m40);
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public short nextShort(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.util.Scanner.staticClass, "nextShort", "(I)S", ref global::java.util.Scanner._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public short nextShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.util.Scanner.staticClass, "nextShort", "()S", ref global::java.util.Scanner._m42);
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public bool hasNextInt()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextInt", "()Z", ref global::java.util.Scanner._m43);
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public bool hasNextInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextInt", "(I)Z", ref global::java.util.Scanner._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public bool hasNextLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextLong", "(I)Z", ref global::java.util.Scanner._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public bool hasNextLong()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextLong", "()Z", ref global::java.util.Scanner._m46);
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public bool hasNextFloat()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextFloat", "()Z", ref global::java.util.Scanner._m47);
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public bool hasNextDouble()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextDouble", "()Z", ref global::java.util.Scanner._m48);
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public bool hasNextBigInteger()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextBigInteger", "()Z", ref global::java.util.Scanner._m49);
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public bool hasNextBigInteger(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextBigInteger", "(I)Z", ref global::java.util.Scanner._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public global::java.math.BigInteger nextBigInteger(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Scanner.staticClass, "nextBigInteger", "(I)Ljava/math/BigInteger;", ref global::java.util.Scanner._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public global::java.math.BigInteger nextBigInteger()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Scanner.staticClass, "nextBigInteger", "()Ljava/math/BigInteger;", ref global::java.util.Scanner._m52) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public bool hasNextBigDecimal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextBigDecimal", "()Z", ref global::java.util.Scanner._m53);
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public global::java.math.BigDecimal nextBigDecimal()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Scanner.staticClass, "nextBigDecimal", "()Ljava/math/BigDecimal;", ref global::java.util.Scanner._m54) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public Scanner(java.nio.channels.ReadableByteChannel arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Scanner._m55.native == global::System.IntPtr.Zero)
				global::java.util.Scanner._m55 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/nio/channels/ReadableByteChannel;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public Scanner(java.nio.channels.ReadableByteChannel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Scanner._m56.native == global::System.IntPtr.Zero)
				global::java.util.Scanner._m56 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/nio/channels/ReadableByteChannel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public Scanner(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Scanner._m57.native == global::System.IntPtr.Zero)
				global::java.util.Scanner._m57 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public Scanner(java.io.File arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Scanner._m58.native == global::System.IntPtr.Zero)
				global::java.util.Scanner._m58 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public Scanner(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Scanner._m59.native == global::System.IntPtr.Zero)
				global::java.util.Scanner._m59 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/io/File;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._m59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public Scanner(java.io.InputStream arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Scanner._m60.native == global::System.IntPtr.Zero)
				global::java.util.Scanner._m60 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public Scanner(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Scanner._m61.native == global::System.IntPtr.Zero)
				global::java.util.Scanner._m61 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m62;
		public Scanner(java.lang.Readable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Scanner._m62.native == global::System.IntPtr.Zero)
				global::java.util.Scanner._m62 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/lang/Readable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Scanner()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Scanner.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Scanner"));
		}
	}
}
