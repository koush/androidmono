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
		internal static global::MonoJavaBridge.MethodId _assertEquals7696;
		public static void assertEquals(java.lang.Object[] arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals7696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals7697;
		public static void assertEquals(java.util.Set arg0, java.util.Set arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals7697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals7698;
		public static void assertEquals(java.lang.String arg0, java.util.Set arg1, java.util.Set arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals7698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals7699;
		public static void assertEquals(java.lang.String arg0, byte[] arg1, byte[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals7699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals7700;
		public static void assertEquals(byte[] arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals7700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals7701;
		public static void assertEquals(java.lang.String arg0, int[] arg1, int[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals7701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals7702;
		public static void assertEquals(int[] arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals7702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals7703;
		public static void assertEquals(java.lang.String arg0, double[] arg1, double[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals7703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals7704;
		public static void assertEquals(java.lang.String arg0, java.lang.Object[] arg1, java.lang.Object[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals7704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals7705;
		public static void assertEquals(double[] arg0, double[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEquals7705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertAssignableFrom7706;
		public static void assertAssignableFrom(java.lang.Class arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertAssignableFrom7706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertAssignableFrom7707;
		public static void assertAssignableFrom(java.lang.Class arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertAssignableFrom7707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotEqual7708;
		public static void assertNotEqual(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotEqual7708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotEqual7709;
		public static void assertNotEqual(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotEqual7709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertMatchesRegex7710;
		public static global::java.util.regex.MatchResult assertMatchesRegex(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallStaticObjectMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertMatchesRegex7710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.regex.MatchResult;
		}
		internal static global::MonoJavaBridge.MethodId _assertMatchesRegex7711;
		public static global::java.util.regex.MatchResult assertMatchesRegex(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallStaticObjectMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertMatchesRegex7711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.regex.MatchResult;
		}
		internal static global::MonoJavaBridge.MethodId _assertContainsRegex7712;
		public static global::java.util.regex.MatchResult assertContainsRegex(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallStaticObjectMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertContainsRegex7712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.regex.MatchResult;
		}
		internal static global::MonoJavaBridge.MethodId _assertContainsRegex7713;
		public static global::java.util.regex.MatchResult assertContainsRegex(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.regex.MatchResult>(@__env.CallStaticObjectMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertContainsRegex7713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.regex.MatchResult;
		}
		internal static global::MonoJavaBridge.MethodId _assertNotMatchesRegex7714;
		public static void assertNotMatchesRegex(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotMatchesRegex7714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotMatchesRegex7715;
		public static void assertNotMatchesRegex(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotMatchesRegex7715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotContainsRegex7716;
		public static void assertNotContainsRegex(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotContainsRegex7716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotContainsRegex7717;
		public static void assertNotContainsRegex(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotContainsRegex7717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertContentsInOrder7718;
		public static void assertContentsInOrder(java.lang.String arg0, java.lang.Iterable arg1, java.lang.Object[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertContentsInOrder7718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertContentsInOrder7719;
		public static void assertContentsInOrder(java.lang.Iterable arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertContentsInOrder7719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertContentsInAnyOrder7720;
		public static void assertContentsInAnyOrder(java.lang.String arg0, java.lang.Iterable arg1, java.lang.Object[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertContentsInAnyOrder7720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertContentsInAnyOrder7721;
		public static void assertContentsInAnyOrder(java.lang.Iterable arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertContentsInAnyOrder7721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEmpty7722;
		public static void assertEmpty(java.lang.Iterable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEmpty7722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertEmpty7723;
		public static void assertEmpty(java.lang.String arg0, java.lang.Iterable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEmpty7723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEmpty7724;
		public static void assertEmpty(java.lang.String arg0, java.util.Map arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEmpty7724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEmpty7725;
		public static void assertEmpty(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertEmpty7725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotEmpty7726;
		public static void assertNotEmpty(java.lang.String arg0, java.lang.Iterable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotEmpty7726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotEmpty7727;
		public static void assertNotEmpty(java.lang.Iterable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotEmpty7727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotEmpty7728;
		public static void assertNotEmpty(java.lang.String arg0, java.util.Map arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotEmpty7728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotEmpty7729;
		public static void assertNotEmpty(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._assertNotEmpty7729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkEqualsAndHashCodeMethods7730;
		public static void checkEqualsAndHashCodeMethods(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._checkEqualsAndHashCodeMethods7730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _checkEqualsAndHashCodeMethods7731;
		public static void checkEqualsAndHashCodeMethods(java.lang.Object arg0, java.lang.Object arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.MoreAsserts.staticClass, global::android.test.MoreAsserts._checkEqualsAndHashCodeMethods7731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.MoreAsserts.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/MoreAsserts"));
			global::android.test.MoreAsserts._assertEquals7696 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "([Ljava/lang/Object;[Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertEquals7697 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "(Ljava/util/Set;Ljava/util/Set;)V");
			global::android.test.MoreAsserts._assertEquals7698 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "(Ljava/lang/String;Ljava/util/Set;Ljava/util/Set;)V");
			global::android.test.MoreAsserts._assertEquals7699 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "(Ljava/lang/String;[B[B)V");
			global::android.test.MoreAsserts._assertEquals7700 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "([B[B)V");
			global::android.test.MoreAsserts._assertEquals7701 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "(Ljava/lang/String;[I[I)V");
			global::android.test.MoreAsserts._assertEquals7702 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "([I[I)V");
			global::android.test.MoreAsserts._assertEquals7703 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "(Ljava/lang/String;[D[D)V");
			global::android.test.MoreAsserts._assertEquals7704 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "(Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertEquals7705 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEquals", "([D[D)V");
			global::android.test.MoreAsserts._assertAssignableFrom7706 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertAssignableFrom", "(Ljava/lang/Class;Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertAssignableFrom7707 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertAssignableFrom", "(Ljava/lang/Class;Ljava/lang/Class;)V");
			global::android.test.MoreAsserts._assertNotEqual7708 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotEqual", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertNotEqual7709 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotEqual", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertMatchesRegex7710 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertMatchesRegex", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/regex/MatchResult;");
			global::android.test.MoreAsserts._assertMatchesRegex7711 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertMatchesRegex", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/regex/MatchResult;");
			global::android.test.MoreAsserts._assertContainsRegex7712 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertContainsRegex", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/regex/MatchResult;");
			global::android.test.MoreAsserts._assertContainsRegex7713 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertContainsRegex", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/regex/MatchResult;");
			global::android.test.MoreAsserts._assertNotMatchesRegex7714 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotMatchesRegex", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.test.MoreAsserts._assertNotMatchesRegex7715 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotMatchesRegex", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.test.MoreAsserts._assertNotContainsRegex7716 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotContainsRegex", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.test.MoreAsserts._assertNotContainsRegex7717 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotContainsRegex", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.test.MoreAsserts._assertContentsInOrder7718 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertContentsInOrder", "(Ljava/lang/String;Ljava/lang/Iterable;[Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertContentsInOrder7719 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertContentsInOrder", "(Ljava/lang/Iterable;[Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertContentsInAnyOrder7720 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertContentsInAnyOrder", "(Ljava/lang/String;Ljava/lang/Iterable;[Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertContentsInAnyOrder7721 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertContentsInAnyOrder", "(Ljava/lang/Iterable;[Ljava/lang/Object;)V");
			global::android.test.MoreAsserts._assertEmpty7722 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEmpty", "(Ljava/lang/Iterable;)V");
			global::android.test.MoreAsserts._assertEmpty7723 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEmpty", "(Ljava/lang/String;Ljava/lang/Iterable;)V");
			global::android.test.MoreAsserts._assertEmpty7724 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEmpty", "(Ljava/lang/String;Ljava/util/Map;)V");
			global::android.test.MoreAsserts._assertEmpty7725 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertEmpty", "(Ljava/util/Map;)V");
			global::android.test.MoreAsserts._assertNotEmpty7726 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotEmpty", "(Ljava/lang/String;Ljava/lang/Iterable;)V");
			global::android.test.MoreAsserts._assertNotEmpty7727 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotEmpty", "(Ljava/lang/Iterable;)V");
			global::android.test.MoreAsserts._assertNotEmpty7728 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotEmpty", "(Ljava/lang/String;Ljava/util/Map;)V");
			global::android.test.MoreAsserts._assertNotEmpty7729 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "assertNotEmpty", "(Ljava/util/Map;)V");
			global::android.test.MoreAsserts._checkEqualsAndHashCodeMethods7730 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "checkEqualsAndHashCodeMethods", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Z)V");
			global::android.test.MoreAsserts._checkEqualsAndHashCodeMethods7731 = @__env.GetStaticMethodIDNoThrow(global::android.test.MoreAsserts.staticClass, "checkEqualsAndHashCodeMethods", "(Ljava/lang/Object;Ljava/lang/Object;Z)V");
		}
	}
}
