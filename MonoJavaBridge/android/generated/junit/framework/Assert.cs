namespace junit.framework
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Assert : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Assert(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _assertTrue31335;
		public static void assertTrue(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertTrue31335.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertTrue31335 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertTrue", "(Ljava/lang/String;Z)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertTrue31335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertTrue31336;
		public static void assertTrue(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertTrue31336.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertTrue31336 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertTrue", "(Z)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertTrue31336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertFalse31337;
		public static void assertFalse(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertFalse31337.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertFalse31337 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertFalse", "(Z)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertFalse31337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertFalse31338;
		public static void assertFalse(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertFalse31338.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertFalse31338 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertFalse", "(Ljava/lang/String;Z)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertFalse31338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fail31339;
		public static void fail(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._fail31339.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._fail31339 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "fail", "(Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._fail31339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fail31340;
		public static void fail()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._fail31340.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._fail31340 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "fail", "()V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._fail31340);
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31341;
		public static void assertEquals(java.lang.String arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertEquals31341.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertEquals31341 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;FFF)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31342;
		public static void assertEquals(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertEquals31342.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertEquals31342 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(FFF)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31343;
		public static void assertEquals(java.lang.String arg0, long arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertEquals31343.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertEquals31343 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;JJ)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31344;
		public static void assertEquals(long arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertEquals31344.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertEquals31344 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(JJ)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31345;
		public static void assertEquals(bool arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertEquals31345.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertEquals31345 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(ZZ)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31346;
		public static void assertEquals(java.lang.String arg0, byte arg1, byte arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertEquals31346.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertEquals31346 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;BB)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31347;
		public static void assertEquals(byte arg0, byte arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertEquals31347.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertEquals31347 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(BB)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31348;
		public static void assertEquals(java.lang.String arg0, char arg1, char arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertEquals31348.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertEquals31348 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;CC)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31349;
		public static void assertEquals(char arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertEquals31349.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertEquals31349 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(CC)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31350;
		public static void assertEquals(java.lang.String arg0, short arg1, short arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertEquals31350.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertEquals31350 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;SS)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31351;
		public static void assertEquals(short arg0, short arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertEquals31351.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertEquals31351 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(SS)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31352;
		public static void assertEquals(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertEquals31352.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertEquals31352 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;II)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31353;
		public static void assertEquals(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertEquals31353.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertEquals31353 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(II)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31354;
		public static void assertEquals(java.lang.String arg0, bool arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertEquals31354.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertEquals31354 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;ZZ)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31355;
		public static void assertEquals(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertEquals31355.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertEquals31355 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31356;
		public static void assertEquals(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertEquals31356.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertEquals31356 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31357;
		public static void assertEquals(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertEquals31357.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertEquals31357 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31358;
		public static void assertEquals(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertEquals31358.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertEquals31358 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31359;
		public static void assertEquals(java.lang.String arg0, double arg1, double arg2, double arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertEquals31359.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertEquals31359 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;DDD)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31360;
		public static void assertEquals(double arg0, double arg1, double arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertEquals31360.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertEquals31360 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(DDD)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotNull31361;
		public static void assertNotNull(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertNotNull31361.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertNotNull31361 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNotNull", "(Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertNotNull31361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotNull31362;
		public static void assertNotNull(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertNotNull31362.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertNotNull31362 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNotNull", "(Ljava/lang/String;Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertNotNull31362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertNull31363;
		public static void assertNull(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertNull31363.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertNull31363 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNull", "(Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertNull31363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertNull31364;
		public static void assertNull(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertNull31364.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertNull31364 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNull", "(Ljava/lang/String;Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertNull31364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertSame31365;
		public static void assertSame(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertSame31365.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertSame31365 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertSame", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertSame31365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertSame31366;
		public static void assertSame(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertSame31366.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertSame31366 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertSame", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertSame31366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotSame31367;
		public static void assertNotSame(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertNotSame31367.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertNotSame31367 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNotSame", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertNotSame31367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotSame31368;
		public static void assertNotSame(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._assertNotSame31368.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._assertNotSame31368 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNotSame", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertNotSame31368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Assert31369;
		protected Assert() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._Assert31369.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._Assert31369 = @__env.GetMethodIDNoThrow(global::junit.framework.Assert.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.Assert.staticClass, global::junit.framework.Assert._Assert31369);
			Init(@__env, handle);
		}
		static Assert()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.Assert.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/Assert"));
		}
		internal static void InitJNI()
		{
		}
	}
}
