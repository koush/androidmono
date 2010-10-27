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
		internal static global::MonoJavaBridge.MethodId _assertEquals12231;
		public static void assertEquals(java.lang.Object[] arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals12231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals12232;
		public static void assertEquals(java.util.Set arg0, java.util.Set arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals12232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals12233;
		public static void assertEquals(java.lang.String arg0, java.util.Set arg1, java.util.Set arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals12233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals12234;
		public static void assertEquals(java.lang.String arg0, byte[] arg1, byte[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals12234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals12235;
		public static void assertEquals(byte[] arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals12235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals12236;
		public static void assertEquals(java.lang.String arg0, int[] arg1, int[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals12236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals12237;
		public static void assertEquals(int[] arg0, int[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals12237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals12238;
		public static void assertEquals(java.lang.String arg0, double[] arg1, double[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals12238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals12239;
		public static void assertEquals(java.lang.String arg0, java.lang.Object[] arg1, java.lang.Object[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals12239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals12240;
		public static void assertEquals(double[] arg0, double[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals12240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertAssignableFrom12241;
		public static void assertAssignableFrom(java.lang.Class arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertAssignableFrom12241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertAssignableFrom12242;
		public static void assertAssignableFrom(java.lang.Class arg0, java.lang.Class arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertAssignableFrom12242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotEqual12243;
		public static void assertNotEqual(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotEqual12243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotEqual12244;
		public static void assertNotEqual(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotEqual12244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertMatchesRegex12245;
		public static global::java.util.regex.MatchResult assertMatchesRegex(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallStaticObjectMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertMatchesRegex12245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.regex.MatchResult;
		}
		internal static global::MonoJavaBridge.MethodId _assertMatchesRegex12246;
		public static global::java.util.regex.MatchResult assertMatchesRegex(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallStaticObjectMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertMatchesRegex12246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.regex.MatchResult;
		}
		internal static global::MonoJavaBridge.MethodId _assertContainsRegex12247;
		public static global::java.util.regex.MatchResult assertContainsRegex(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallStaticObjectMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertContainsRegex12247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.regex.MatchResult;
		}
		internal static global::MonoJavaBridge.MethodId _assertContainsRegex12248;
		public static global::java.util.regex.MatchResult assertContainsRegex(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallStaticObjectMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertContainsRegex12248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.regex.MatchResult;
		}
		internal static global::MonoJavaBridge.MethodId _assertNotMatchesRegex12249;
		public static void assertNotMatchesRegex(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotMatchesRegex12249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotMatchesRegex12250;
		public static void assertNotMatchesRegex(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotMatchesRegex12250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotContainsRegex12251;
		public static void assertNotContainsRegex(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotContainsRegex12251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotContainsRegex12252;
		public static void assertNotContainsRegex(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotContainsRegex12252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertContentsInOrder12253;
		public static void assertContentsInOrder(java.lang.String arg0, java.lang.Iterable arg1, java.lang.Object[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertContentsInOrder12253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertContentsInOrder12254;
		public static void assertContentsInOrder(java.lang.Iterable arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertContentsInOrder12254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertContentsInAnyOrder12255;
		public static void assertContentsInAnyOrder(java.lang.String arg0, java.lang.Iterable arg1, java.lang.Object[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertContentsInAnyOrder12255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertContentsInAnyOrder12256;
		public static void assertContentsInAnyOrder(java.lang.Iterable arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertContentsInAnyOrder12256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEmpty12257;
		public static void assertEmpty(java.lang.Iterable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEmpty12257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertEmpty12258;
		public static void assertEmpty(java.lang.String arg0, java.lang.Iterable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEmpty12258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEmpty12259;
		public static void assertEmpty(java.lang.String arg0, java.util.Map arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEmpty12259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEmpty12260;
		public static void assertEmpty(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEmpty12260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotEmpty12261;
		public static void assertNotEmpty(java.lang.String arg0, java.lang.Iterable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotEmpty12261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotEmpty12262;
		public static void assertNotEmpty(java.lang.Iterable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotEmpty12262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotEmpty12263;
		public static void assertNotEmpty(java.lang.String arg0, java.util.Map arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotEmpty12263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotEmpty12264;
		public static void assertNotEmpty(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotEmpty12264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkEqualsAndHashCodeMethods12265;
		public static void checkEqualsAndHashCodeMethods(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2, bool arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._checkEqualsAndHashCodeMethods12265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _checkEqualsAndHashCodeMethods12266;
		public static void checkEqualsAndHashCodeMethods(java.lang.Object arg0, java.lang.Object arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._checkEqualsAndHashCodeMethods12266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.MoreAsserts.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/MoreAsserts"));
			global::android.test.MoreAsserts._assertEquals12231 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "([Ljava/lang/Object;[Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertEquals12232 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "(Ljava/util/Set;Ljava/util/Set;)V");
			global::android.test.MoreAsserts._assertEquals12233 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "(Ljava/lang/String;Ljava/util/Set;Ljava/util/Set;)V");
			global::android.test.MoreAsserts._assertEquals12234 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "(Ljava/lang/String;[B[B)V");
			global::android.test.MoreAsserts._assertEquals12235 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "([B[B)V");
			global::android.test.MoreAsserts._assertEquals12236 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "(Ljava/lang/String;[I[I)V");
			global::android.test.MoreAsserts._assertEquals12237 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "([I[I)V");
			global::android.test.MoreAsserts._assertEquals12238 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "(Ljava/lang/String;[D[D)V");
			global::android.test.MoreAsserts._assertEquals12239 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "(Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertEquals12240 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "([D[D)V");
			global::android.test.MoreAsserts._assertAssignableFrom12241 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertAssignableFrom", "(Ljava/lang/Class;Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertAssignableFrom12242 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertAssignableFrom", "(Ljava/lang/Class;Ljava/lang/Class;)V");
			global::android.test.MoreAsserts._assertNotEqual12243 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotEqual", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertNotEqual12244 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotEqual", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertMatchesRegex12245 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertMatchesRegex", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/regex/MatchResult;");
			global::android.test.MoreAsserts._assertMatchesRegex12246 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertMatchesRegex", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/regex/MatchResult;");
			global::android.test.MoreAsserts._assertContainsRegex12247 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertContainsRegex", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/regex/MatchResult;");
			global::android.test.MoreAsserts._assertContainsRegex12248 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertContainsRegex", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/regex/MatchResult;");
			global::android.test.MoreAsserts._assertNotMatchesRegex12249 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotMatchesRegex", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.test.MoreAsserts._assertNotMatchesRegex12250 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotMatchesRegex", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.test.MoreAsserts._assertNotContainsRegex12251 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotContainsRegex", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.test.MoreAsserts._assertNotContainsRegex12252 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotContainsRegex", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.test.MoreAsserts._assertContentsInOrder12253 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertContentsInOrder", "(Ljava/lang/String;Ljava/lang/Iterable;[Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertContentsInOrder12254 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertContentsInOrder", "(Ljava/lang/Iterable;[Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertContentsInAnyOrder12255 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertContentsInAnyOrder", "(Ljava/lang/String;Ljava/lang/Iterable;[Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertContentsInAnyOrder12256 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertContentsInAnyOrder", "(Ljava/lang/Iterable;[Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertEmpty12257 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEmpty", "(Ljava/lang/Iterable;)V");
			global::android.test.MoreAsserts._assertEmpty12258 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEmpty", "(Ljava/lang/String;Ljava/lang/Iterable;)V");
			global::android.test.MoreAsserts._assertEmpty12259 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEmpty", "(Ljava/lang/String;Ljava/util/Map;)V");
			global::android.test.MoreAsserts._assertEmpty12260 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEmpty", "(Ljava/util/Map;)V");
			global::android.test.MoreAsserts._assertNotEmpty12261 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotEmpty", "(Ljava/lang/String;Ljava/lang/Iterable;)V");
			global::android.test.MoreAsserts._assertNotEmpty12262 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotEmpty", "(Ljava/lang/Iterable;)V");
			global::android.test.MoreAsserts._assertNotEmpty12263 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotEmpty", "(Ljava/lang/String;Ljava/util/Map;)V");
			global::android.test.MoreAsserts._assertNotEmpty12264 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotEmpty", "(Ljava/util/Map;)V");
			global::android.test.MoreAsserts._checkEqualsAndHashCodeMethods12265 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "checkEqualsAndHashCodeMethods", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Z)V");
			global::android.test.MoreAsserts._checkEqualsAndHashCodeMethods12266 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "checkEqualsAndHashCodeMethods", "(Ljava/lang/Object;Ljava/lang/Object;Z)V");
		}
	}
}
