namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Scanner : java.lang.Object, Iterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Scanner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString26638;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Scanner.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.Scanner._toString26638) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasNext26639;
		public bool hasNext(java.util.regex.Pattern arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNext", "(Ljava/util/regex/Pattern;)Z", ref global::java.util.Scanner._hasNext26639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNext26640;
		public bool hasNext(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNext", "(Ljava/lang/String;)Z", ref global::java.util.Scanner._hasNext26640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNext26641;
		public bool hasNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNext", "()Z", ref global::java.util.Scanner._hasNext26641);
		}
		internal static global::MonoJavaBridge.MethodId _next26642;
		public global::java.lang.String next(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Scanner.staticClass, "next", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.util.Scanner._next26642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _next26643;
		public global::java.lang.Object next()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Scanner.staticClass, "next", "()Ljava/lang/Object;", ref global::java.util.Scanner._next26643) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _next26644;
		public global::java.lang.String next(java.util.regex.Pattern arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Scanner.staticClass, "next", "(Ljava/util/regex/Pattern;)Ljava/lang/String;", ref global::java.util.Scanner._next26644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _remove26645;
		public void remove()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Scanner.staticClass, "remove", "()V", ref global::java.util.Scanner._remove26645);
		}
		internal static global::MonoJavaBridge.MethodId _close26646;
		public void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Scanner.staticClass, "close", "()V", ref global::java.util.Scanner._close26646);
		}
		internal static global::MonoJavaBridge.MethodId _reset26647;
		public global::java.util.Scanner reset()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Scanner>(this, global::java.util.Scanner.staticClass, "reset", "()Ljava/util/Scanner;", ref global::java.util.Scanner._reset26647) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _nextDouble26648;
		public double nextDouble()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.util.Scanner.staticClass, "nextDouble", "()D", ref global::java.util.Scanner._nextDouble26648);
		}
		internal static global::MonoJavaBridge.MethodId _nextInt26649;
		public int nextInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Scanner.staticClass, "nextInt", "(I)I", ref global::java.util.Scanner._nextInt26649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextInt26650;
		public int nextInt()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Scanner.staticClass, "nextInt", "()I", ref global::java.util.Scanner._nextInt26650);
		}
		internal static global::MonoJavaBridge.MethodId _nextLong26651;
		public long nextLong()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.Scanner.staticClass, "nextLong", "()J", ref global::java.util.Scanner._nextLong26651);
		}
		internal static global::MonoJavaBridge.MethodId _nextLong26652;
		public long nextLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.Scanner.staticClass, "nextLong", "(I)J", ref global::java.util.Scanner._nextLong26652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skip26653;
		public global::java.util.Scanner skip(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Scanner>(this, global::java.util.Scanner.staticClass, "skip", "(Ljava/lang/String;)Ljava/util/Scanner;", ref global::java.util.Scanner._skip26653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _skip26654;
		public global::java.util.Scanner skip(java.util.regex.Pattern arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Scanner>(this, global::java.util.Scanner.staticClass, "skip", "(Ljava/util/regex/Pattern;)Ljava/util/Scanner;", ref global::java.util.Scanner._skip26654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _locale26655;
		public global::java.util.Locale locale()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Locale>(this, global::java.util.Scanner.staticClass, "locale", "()Ljava/util/Locale;", ref global::java.util.Scanner._locale26655) as java.util.Locale;
		}
		internal static global::MonoJavaBridge.MethodId _match26656;
		public global::java.util.regex.MatchResult match()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.regex.MatchResult>(this, global::java.util.Scanner.staticClass, "match", "()Ljava/util/regex/MatchResult;", ref global::java.util.Scanner._match26656) as java.util.regex.MatchResult;
		}
		internal static global::MonoJavaBridge.MethodId _nextBoolean26657;
		public bool nextBoolean()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "nextBoolean", "()Z", ref global::java.util.Scanner._nextBoolean26657);
		}
		internal static global::MonoJavaBridge.MethodId _nextFloat26658;
		public float nextFloat()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.util.Scanner.staticClass, "nextFloat", "()F", ref global::java.util.Scanner._nextFloat26658);
		}
		internal static global::MonoJavaBridge.MethodId _delimiter26659;
		public global::java.util.regex.Pattern delimiter()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.regex.Pattern>(this, global::java.util.Scanner.staticClass, "delimiter", "()Ljava/util/regex/Pattern;", ref global::java.util.Scanner._delimiter26659) as java.util.regex.Pattern;
		}
		internal static global::MonoJavaBridge.MethodId _ioException26660;
		public global::java.io.IOException ioException()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Scanner.staticClass, "ioException", "()Ljava/io/IOException;", ref global::java.util.Scanner._ioException26660) as java.io.IOException;
		}
		internal static global::MonoJavaBridge.MethodId _radix26661;
		public int radix()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Scanner.staticClass, "radix", "()I", ref global::java.util.Scanner._radix26661);
		}
		internal static global::MonoJavaBridge.MethodId _useDelimiter26662;
		public global::java.util.Scanner useDelimiter(java.util.regex.Pattern arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Scanner>(this, global::java.util.Scanner.staticClass, "useDelimiter", "(Ljava/util/regex/Pattern;)Ljava/util/Scanner;", ref global::java.util.Scanner._useDelimiter26662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _useDelimiter26663;
		public global::java.util.Scanner useDelimiter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Scanner>(this, global::java.util.Scanner.staticClass, "useDelimiter", "(Ljava/lang/String;)Ljava/util/Scanner;", ref global::java.util.Scanner._useDelimiter26663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _useLocale26664;
		public global::java.util.Scanner useLocale(java.util.Locale arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Scanner>(this, global::java.util.Scanner.staticClass, "useLocale", "(Ljava/util/Locale;)Ljava/util/Scanner;", ref global::java.util.Scanner._useLocale26664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _useRadix26665;
		public global::java.util.Scanner useRadix(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Scanner>(this, global::java.util.Scanner.staticClass, "useRadix", "(I)Ljava/util/Scanner;", ref global::java.util.Scanner._useRadix26665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Scanner;
		}
		internal static global::MonoJavaBridge.MethodId _hasNextLine26666;
		public bool hasNextLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextLine", "()Z", ref global::java.util.Scanner._hasNextLine26666);
		}
		internal static global::MonoJavaBridge.MethodId _nextLine26667;
		public global::java.lang.String nextLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Scanner.staticClass, "nextLine", "()Ljava/lang/String;", ref global::java.util.Scanner._nextLine26667) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _findInLine26668;
		public global::java.lang.String findInLine(java.util.regex.Pattern arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Scanner.staticClass, "findInLine", "(Ljava/util/regex/Pattern;)Ljava/lang/String;", ref global::java.util.Scanner._findInLine26668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _findInLine26669;
		public global::java.lang.String findInLine(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Scanner.staticClass, "findInLine", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.util.Scanner._findInLine26669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _findWithinHorizon26670;
		public global::java.lang.String findWithinHorizon(java.util.regex.Pattern arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Scanner.staticClass, "findWithinHorizon", "(Ljava/util/regex/Pattern;I)Ljava/lang/String;", ref global::java.util.Scanner._findWithinHorizon26670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _findWithinHorizon26671;
		public global::java.lang.String findWithinHorizon(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Scanner.staticClass, "findWithinHorizon", "(Ljava/lang/String;I)Ljava/lang/String;", ref global::java.util.Scanner._findWithinHorizon26671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasNextBoolean26672;
		public bool hasNextBoolean()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextBoolean", "()Z", ref global::java.util.Scanner._hasNextBoolean26672);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextByte26673;
		public bool hasNextByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextByte", "()Z", ref global::java.util.Scanner._hasNextByte26673);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextByte26674;
		public bool hasNextByte(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextByte", "(I)Z", ref global::java.util.Scanner._hasNextByte26674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextByte26675;
		public byte nextByte(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.util.Scanner.staticClass, "nextByte", "(I)B", ref global::java.util.Scanner._nextByte26675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextByte26676;
		public byte nextByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.util.Scanner.staticClass, "nextByte", "()B", ref global::java.util.Scanner._nextByte26676);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextShort26677;
		public bool hasNextShort(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextShort", "(I)Z", ref global::java.util.Scanner._hasNextShort26677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNextShort26678;
		public bool hasNextShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextShort", "()Z", ref global::java.util.Scanner._hasNextShort26678);
		}
		internal static global::MonoJavaBridge.MethodId _nextShort26679;
		public short nextShort(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.util.Scanner.staticClass, "nextShort", "(I)S", ref global::java.util.Scanner._nextShort26679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextShort26680;
		public short nextShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.util.Scanner.staticClass, "nextShort", "()S", ref global::java.util.Scanner._nextShort26680);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextInt26681;
		public bool hasNextInt()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextInt", "()Z", ref global::java.util.Scanner._hasNextInt26681);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextInt26682;
		public bool hasNextInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextInt", "(I)Z", ref global::java.util.Scanner._hasNextInt26682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNextLong26683;
		public bool hasNextLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextLong", "(I)Z", ref global::java.util.Scanner._hasNextLong26683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasNextLong26684;
		public bool hasNextLong()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextLong", "()Z", ref global::java.util.Scanner._hasNextLong26684);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextFloat26685;
		public bool hasNextFloat()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextFloat", "()Z", ref global::java.util.Scanner._hasNextFloat26685);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextDouble26686;
		public bool hasNextDouble()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextDouble", "()Z", ref global::java.util.Scanner._hasNextDouble26686);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextBigInteger26687;
		public bool hasNextBigInteger()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextBigInteger", "()Z", ref global::java.util.Scanner._hasNextBigInteger26687);
		}
		internal static global::MonoJavaBridge.MethodId _hasNextBigInteger26688;
		public bool hasNextBigInteger(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextBigInteger", "(I)Z", ref global::java.util.Scanner._hasNextBigInteger26688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextBigInteger26689;
		public global::java.math.BigInteger nextBigInteger(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Scanner.staticClass, "nextBigInteger", "(I)Ljava/math/BigInteger;", ref global::java.util.Scanner._nextBigInteger26689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _nextBigInteger26690;
		public global::java.math.BigInteger nextBigInteger()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Scanner.staticClass, "nextBigInteger", "()Ljava/math/BigInteger;", ref global::java.util.Scanner._nextBigInteger26690) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _hasNextBigDecimal26691;
		public bool hasNextBigDecimal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Scanner.staticClass, "hasNextBigDecimal", "()Z", ref global::java.util.Scanner._hasNextBigDecimal26691);
		}
		internal static global::MonoJavaBridge.MethodId _nextBigDecimal26692;
		public global::java.math.BigDecimal nextBigDecimal()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Scanner.staticClass, "nextBigDecimal", "()Ljava/math/BigDecimal;", ref global::java.util.Scanner._nextBigDecimal26692) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26693;
		public Scanner(java.nio.channels.ReadableByteChannel arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Scanner._Scanner26693.native == global::System.IntPtr.Zero)
				global::java.util.Scanner._Scanner26693 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/nio/channels/ReadableByteChannel;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26694;
		public Scanner(java.nio.channels.ReadableByteChannel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Scanner._Scanner26694.native == global::System.IntPtr.Zero)
				global::java.util.Scanner._Scanner26694 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/nio/channels/ReadableByteChannel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26695;
		public Scanner(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Scanner._Scanner26695.native == global::System.IntPtr.Zero)
				global::java.util.Scanner._Scanner26695 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26696;
		public Scanner(java.io.File arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Scanner._Scanner26696.native == global::System.IntPtr.Zero)
				global::java.util.Scanner._Scanner26696 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26697;
		public Scanner(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Scanner._Scanner26697.native == global::System.IntPtr.Zero)
				global::java.util.Scanner._Scanner26697 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/io/File;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26698;
		public Scanner(java.io.InputStream arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Scanner._Scanner26698.native == global::System.IntPtr.Zero)
				global::java.util.Scanner._Scanner26698 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26699;
		public Scanner(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Scanner._Scanner26699.native == global::System.IntPtr.Zero)
				global::java.util.Scanner._Scanner26699 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scanner26700;
		public Scanner(java.lang.Readable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Scanner._Scanner26700.native == global::System.IntPtr.Zero)
				global::java.util.Scanner._Scanner26700 = @__env.GetMethodIDNoThrow(global::java.util.Scanner.staticClass, "<init>", "(Ljava/lang/Readable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Scanner.staticClass, global::java.util.Scanner._Scanner26700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Scanner()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Scanner.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Scanner"));
		}
		internal static void InitJNI()
		{
		}
	}
}
