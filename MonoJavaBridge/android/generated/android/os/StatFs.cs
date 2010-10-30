namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StatFs : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StatFs(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.StatFs.staticClass, "finalize", "()V", ref global::android.os.StatFs._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void restat(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.StatFs.staticClass, "restat", "(Ljava/lang/String;)V", ref global::android.os.StatFs._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int BlockSize
		{
			get
			{
				return getBlockSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getBlockSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.StatFs.staticClass, "getBlockSize", "()I", ref global::android.os.StatFs._m2);
		}
		public new int BlockCount
		{
			get
			{
				return getBlockCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getBlockCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.StatFs.staticClass, "getBlockCount", "()I", ref global::android.os.StatFs._m3);
		}
		public new int FreeBlocks
		{
			get
			{
				return getFreeBlocks();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getFreeBlocks()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.StatFs.staticClass, "getFreeBlocks", "()I", ref global::android.os.StatFs._m4);
		}
		public new int AvailableBlocks
		{
			get
			{
				return getAvailableBlocks();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getAvailableBlocks()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.StatFs.staticClass, "getAvailableBlocks", "()I", ref global::android.os.StatFs._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public StatFs(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.StatFs._m6.native == global::System.IntPtr.Zero)
				global::android.os.StatFs._m6 = @__env.GetMethodIDNoThrow(global::android.os.StatFs.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.StatFs.staticClass, global::android.os.StatFs._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static StatFs()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.StatFs.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/StatFs"));
		}
		internal static void InitJNI()
		{
		}
	}
}
