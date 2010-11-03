namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LinkedHashSet : java.util.HashSet, Set, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LinkedHashSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public LinkedHashSet(int arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.LinkedHashSet._m0.native == global::System.IntPtr.Zero)
				global::java.util.LinkedHashSet._m0 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashSet.staticClass, "<init>", "(IF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashSet.staticClass, global::java.util.LinkedHashSet._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public LinkedHashSet(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.LinkedHashSet._m1.native == global::System.IntPtr.Zero)
				global::java.util.LinkedHashSet._m1 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashSet.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashSet.staticClass, global::java.util.LinkedHashSet._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public LinkedHashSet() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.LinkedHashSet._m2.native == global::System.IntPtr.Zero)
				global::java.util.LinkedHashSet._m2 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashSet.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashSet.staticClass, global::java.util.LinkedHashSet._m2);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public LinkedHashSet(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.LinkedHashSet._m3.native == global::System.IntPtr.Zero)
				global::java.util.LinkedHashSet._m3 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashSet.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashSet.staticClass, global::java.util.LinkedHashSet._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static LinkedHashSet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.LinkedHashSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/LinkedHashSet"));
		}
	}
}
