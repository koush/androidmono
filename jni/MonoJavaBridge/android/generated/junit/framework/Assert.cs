namespace junit.framework
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Assert : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Assert()
		{
			InitJNI();
		}
		protected Assert(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _assertTrue31216;
		public static void assertTrue(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertTrue31216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertTrue31217;
		public static void assertTrue(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertTrue31217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertFalse31218;
		public static void assertFalse(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertFalse31218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertFalse31219;
		public static void assertFalse(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertFalse31219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fail31220;
		public static void fail(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._fail31220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fail31221;
		public static void fail() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._fail31221);
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31222;
		public static void assertEquals(java.lang.String arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31223;
		public static void assertEquals(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31224;
		public static void assertEquals(java.lang.String arg0, long arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31225;
		public static void assertEquals(long arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31226;
		public static void assertEquals(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31227;
		public static void assertEquals(java.lang.String arg0, byte arg1, byte arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31228;
		public static void assertEquals(byte arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31229;
		public static void assertEquals(java.lang.String arg0, char arg1, char arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31230;
		public static void assertEquals(char arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31231;
		public static void assertEquals(java.lang.String arg0, short arg1, short arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31232;
		public static void assertEquals(short arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31233;
		public static void assertEquals(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31234;
		public static void assertEquals(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31235;
		public static void assertEquals(java.lang.String arg0, bool arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31236;
		public static void assertEquals(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31237;
		public static void assertEquals(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31238;
		public static void assertEquals(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31239;
		public static void assertEquals(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31240;
		public static void assertEquals(java.lang.String arg0, double arg1, double arg2, double arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals31241;
		public static void assertEquals(double arg0, double arg1, double arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals31241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotNull31242;
		public static void assertNotNull(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertNotNull31242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotNull31243;
		public static void assertNotNull(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertNotNull31243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertNull31244;
		public static void assertNull(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertNull31244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertNull31245;
		public static void assertNull(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertNull31245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertSame31246;
		public static void assertSame(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertSame31246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertSame31247;
		public static void assertSame(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertSame31247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotSame31248;
		public static void assertNotSame(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertNotSame31248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotSame31249;
		public static void assertNotSame(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertNotSame31249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Assert31250;
		protected Assert()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.Assert.staticClass, global::junit.framework.Assert._Assert31250);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.Assert.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/Assert"));
			global::junit.framework.Assert._assertTrue31216 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertTrue", "(Ljava/lang/String;Z)V");
			global::junit.framework.Assert._assertTrue31217 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertTrue", "(Z)V");
			global::junit.framework.Assert._assertFalse31218 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertFalse", "(Z)V");
			global::junit.framework.Assert._assertFalse31219 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertFalse", "(Ljava/lang/String;Z)V");
			global::junit.framework.Assert._fail31220 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "fail", "(Ljava/lang/String;)V");
			global::junit.framework.Assert._fail31221 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "fail", "()V");
			global::junit.framework.Assert._assertEquals31222 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;FFF)V");
			global::junit.framework.Assert._assertEquals31223 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(FFF)V");
			global::junit.framework.Assert._assertEquals31224 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;JJ)V");
			global::junit.framework.Assert._assertEquals31225 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(JJ)V");
			global::junit.framework.Assert._assertEquals31226 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(ZZ)V");
			global::junit.framework.Assert._assertEquals31227 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;BB)V");
			global::junit.framework.Assert._assertEquals31228 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(BB)V");
			global::junit.framework.Assert._assertEquals31229 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;CC)V");
			global::junit.framework.Assert._assertEquals31230 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(CC)V");
			global::junit.framework.Assert._assertEquals31231 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;SS)V");
			global::junit.framework.Assert._assertEquals31232 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(SS)V");
			global::junit.framework.Assert._assertEquals31233 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;II)V");
			global::junit.framework.Assert._assertEquals31234 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(II)V");
			global::junit.framework.Assert._assertEquals31235 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;ZZ)V");
			global::junit.framework.Assert._assertEquals31236 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			global::junit.framework.Assert._assertEquals31237 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			global::junit.framework.Assert._assertEquals31238 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::junit.framework.Assert._assertEquals31239 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::junit.framework.Assert._assertEquals31240 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;DDD)V");
			global::junit.framework.Assert._assertEquals31241 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(DDD)V");
			global::junit.framework.Assert._assertNotNull31242 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNotNull", "(Ljava/lang/Object;)V");
			global::junit.framework.Assert._assertNotNull31243 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNotNull", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::junit.framework.Assert._assertNull31244 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNull", "(Ljava/lang/Object;)V");
			global::junit.framework.Assert._assertNull31245 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNull", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::junit.framework.Assert._assertSame31246 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertSame", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			global::junit.framework.Assert._assertSame31247 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertSame", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			global::junit.framework.Assert._assertNotSame31248 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNotSame", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			global::junit.framework.Assert._assertNotSame31249 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNotSame", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			global::junit.framework.Assert._Assert31250 = @__env.GetMethodIDNoThrow(global::junit.framework.Assert.staticClass, "<init>", "()V");
		}
	}
}
