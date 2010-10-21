namespace android.test
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class MoreAsserts : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MoreAsserts()
		{
			InitJNI();
		}
		internal MoreAsserts(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals12174;
		public static void assertEquals(java.lang.Object[] arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals12174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals12175;
		public static void assertEquals(java.util.Set arg0, java.util.Set arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals12175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals12176;
		public static void assertEquals(java.lang.String arg0, java.util.Set arg1, java.util.Set arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals12176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals12177;
		public static void assertEquals(java.lang.String arg0, byte[] arg1, byte[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals12177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals12178;
		public static void assertEquals(byte[] arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals12178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals12179;
		public static void assertEquals(java.lang.String arg0, int[] arg1, int[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals12179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals12180;
		public static void assertEquals(int[] arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals12180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals12181;
		public static void assertEquals(java.lang.String arg0, double[] arg1, double[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals12181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals12182;
		public static void assertEquals(java.lang.String arg0, java.lang.Object[] arg1, java.lang.Object[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals12182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals12183;
		public static void assertEquals(double[] arg0, double[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals12183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertAssignableFrom12184;
		public static void assertAssignableFrom(java.lang.Class arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertAssignableFrom12184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertAssignableFrom12185;
		public static void assertAssignableFrom(java.lang.Class arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertAssignableFrom12185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotEqual12186;
		public static void assertNotEqual(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotEqual12186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotEqual12187;
		public static void assertNotEqual(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotEqual12187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertMatchesRegex12188;
		public static global::java.util.regex.MatchResult assertMatchesRegex(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallStaticObjectMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertMatchesRegex12188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.regex.MatchResult;
		}
		internal static global::MonoJavaBridge.MethodId _assertMatchesRegex12189;
		public static global::java.util.regex.MatchResult assertMatchesRegex(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallStaticObjectMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertMatchesRegex12189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.regex.MatchResult;
		}
		internal static global::MonoJavaBridge.MethodId _assertContainsRegex12190;
		public static global::java.util.regex.MatchResult assertContainsRegex(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallStaticObjectMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertContainsRegex12190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.regex.MatchResult;
		}
		internal static global::MonoJavaBridge.MethodId _assertContainsRegex12191;
		public static global::java.util.regex.MatchResult assertContainsRegex(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallStaticObjectMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertContainsRegex12191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.regex.MatchResult;
		}
		internal static global::MonoJavaBridge.MethodId _assertNotMatchesRegex12192;
		public static void assertNotMatchesRegex(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotMatchesRegex12192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotMatchesRegex12193;
		public static void assertNotMatchesRegex(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotMatchesRegex12193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotContainsRegex12194;
		public static void assertNotContainsRegex(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotContainsRegex12194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotContainsRegex12195;
		public static void assertNotContainsRegex(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotContainsRegex12195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertContentsInOrder12196;
		public static void assertContentsInOrder(java.lang.String arg0, java.lang.Iterable arg1, java.lang.Object[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertContentsInOrder12196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertContentsInOrder12197;
		public static void assertContentsInOrder(java.lang.Iterable arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertContentsInOrder12197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertContentsInAnyOrder12198;
		public static void assertContentsInAnyOrder(java.lang.String arg0, java.lang.Iterable arg1, java.lang.Object[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertContentsInAnyOrder12198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertContentsInAnyOrder12199;
		public static void assertContentsInAnyOrder(java.lang.Iterable arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertContentsInAnyOrder12199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEmpty12200;
		public static void assertEmpty(java.lang.Iterable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEmpty12200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertEmpty12201;
		public static void assertEmpty(java.lang.String arg0, java.lang.Iterable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEmpty12201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEmpty12202;
		public static void assertEmpty(java.lang.String arg0, java.util.Map arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEmpty12202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEmpty12203;
		public static void assertEmpty(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEmpty12203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotEmpty12204;
		public static void assertNotEmpty(java.lang.String arg0, java.lang.Iterable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotEmpty12204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotEmpty12205;
		public static void assertNotEmpty(java.lang.Iterable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotEmpty12205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotEmpty12206;
		public static void assertNotEmpty(java.lang.String arg0, java.util.Map arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotEmpty12206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotEmpty12207;
		public static void assertNotEmpty(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotEmpty12207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkEqualsAndHashCodeMethods12208;
		public static void checkEqualsAndHashCodeMethods(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._checkEqualsAndHashCodeMethods12208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _checkEqualsAndHashCodeMethods12209;
		public static void checkEqualsAndHashCodeMethods(java.lang.Object arg0, java.lang.Object arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._checkEqualsAndHashCodeMethods12209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.MoreAsserts.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/MoreAsserts"));
			global::android.test.MoreAsserts._assertEquals12174 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "([Ljava/lang/Object;[Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertEquals12175 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "(Ljava/util/Set;Ljava/util/Set;)V");
			global::android.test.MoreAsserts._assertEquals12176 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "(Ljava/lang/String;Ljava/util/Set;Ljava/util/Set;)V");
			global::android.test.MoreAsserts._assertEquals12177 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "(Ljava/lang/String;[B[B)V");
			global::android.test.MoreAsserts._assertEquals12178 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "([B[B)V");
			global::android.test.MoreAsserts._assertEquals12179 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "(Ljava/lang/String;[I[I)V");
			global::android.test.MoreAsserts._assertEquals12180 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "([I[I)V");
			global::android.test.MoreAsserts._assertEquals12181 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "(Ljava/lang/String;[D[D)V");
			global::android.test.MoreAsserts._assertEquals12182 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "(Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertEquals12183 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "([D[D)V");
			global::android.test.MoreAsserts._assertAssignableFrom12184 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertAssignableFrom", "(Ljava/lang/Class;Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertAssignableFrom12185 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertAssignableFrom", "(Ljava/lang/Class;Ljava/lang/Class;)V");
			global::android.test.MoreAsserts._assertNotEqual12186 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotEqual", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertNotEqual12187 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotEqual", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertMatchesRegex12188 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertMatchesRegex", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/regex/MatchResult;");
			global::android.test.MoreAsserts._assertMatchesRegex12189 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertMatchesRegex", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/regex/MatchResult;");
			global::android.test.MoreAsserts._assertContainsRegex12190 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertContainsRegex", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/regex/MatchResult;");
			global::android.test.MoreAsserts._assertContainsRegex12191 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertContainsRegex", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/regex/MatchResult;");
			global::android.test.MoreAsserts._assertNotMatchesRegex12192 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotMatchesRegex", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.test.MoreAsserts._assertNotMatchesRegex12193 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotMatchesRegex", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.test.MoreAsserts._assertNotContainsRegex12194 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotContainsRegex", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.test.MoreAsserts._assertNotContainsRegex12195 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotContainsRegex", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.test.MoreAsserts._assertContentsInOrder12196 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertContentsInOrder", "(Ljava/lang/String;Ljava/lang/Iterable;[Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertContentsInOrder12197 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertContentsInOrder", "(Ljava/lang/Iterable;[Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertContentsInAnyOrder12198 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertContentsInAnyOrder", "(Ljava/lang/String;Ljava/lang/Iterable;[Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertContentsInAnyOrder12199 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertContentsInAnyOrder", "(Ljava/lang/Iterable;[Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertEmpty12200 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEmpty", "(Ljava/lang/Iterable;)V");
			global::android.test.MoreAsserts._assertEmpty12201 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEmpty", "(Ljava/lang/String;Ljava/lang/Iterable;)V");
			global::android.test.MoreAsserts._assertEmpty12202 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEmpty", "(Ljava/lang/String;Ljava/util/Map;)V");
			global::android.test.MoreAsserts._assertEmpty12203 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEmpty", "(Ljava/util/Map;)V");
			global::android.test.MoreAsserts._assertNotEmpty12204 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotEmpty", "(Ljava/lang/String;Ljava/lang/Iterable;)V");
			global::android.test.MoreAsserts._assertNotEmpty12205 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotEmpty", "(Ljava/lang/Iterable;)V");
			global::android.test.MoreAsserts._assertNotEmpty12206 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotEmpty", "(Ljava/lang/String;Ljava/util/Map;)V");
			global::android.test.MoreAsserts._assertNotEmpty12207 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotEmpty", "(Ljava/util/Map;)V");
			global::android.test.MoreAsserts._checkEqualsAndHashCodeMethods12208 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "checkEqualsAndHashCodeMethods", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Z)V");
			global::android.test.MoreAsserts._checkEqualsAndHashCodeMethods12209 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "checkEqualsAndHashCodeMethods", "(Ljava/lang/Object;Ljava/lang/Object;Z)V");
		}
	}
}
