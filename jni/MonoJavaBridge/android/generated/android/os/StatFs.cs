namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StatFs : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StatFs()
		{
			InitJNI();
		}
		protected StatFs(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize6721;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.StatFs._finalize6721);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.StatFs.staticClass, global::android.os.StatFs._finalize6721);
		}
		internal static global::MonoJavaBridge.MethodId _restat6722;
		public virtual void restat(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.StatFs._restat6722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.StatFs.staticClass, global::android.os.StatFs._restat6722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int BlockSize
		{
			get
			{
				return getBlockSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBlockSize6723;
		public virtual int getBlockSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.StatFs._getBlockSize6723);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.StatFs.staticClass, global::android.os.StatFs._getBlockSize6723);
		}
		public new int BlockCount
		{
			get
			{
				return getBlockCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBlockCount6724;
		public virtual int getBlockCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.StatFs._getBlockCount6724);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.StatFs.staticClass, global::android.os.StatFs._getBlockCount6724);
		}
		public new int FreeBlocks
		{
			get
			{
				return getFreeBlocks();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFreeBlocks6725;
		public virtual int getFreeBlocks() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.StatFs._getFreeBlocks6725);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.StatFs.staticClass, global::android.os.StatFs._getFreeBlocks6725);
		}
		public new int AvailableBlocks
		{
			get
			{
				return getAvailableBlocks();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAvailableBlocks6726;
		public virtual int getAvailableBlocks() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.StatFs._getAvailableBlocks6726);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.StatFs.staticClass, global::android.os.StatFs._getAvailableBlocks6726);
		}
		internal static global::MonoJavaBridge.MethodId _StatFs6727;
		public StatFs(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.StatFs.staticClass, global::android.os.StatFs._StatFs6727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.StatFs.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/StatFs"));
			global::android.os.StatFs._finalize6721 = @__env.GetMethodIDNoThrow(global::android.os.StatFs.staticClass, "finalize", "()V");
			global::android.os.StatFs._restat6722 = @__env.GetMethodIDNoThrow(global::android.os.StatFs.staticClass, "restat", "(Ljava/lang/String;)V");
			global::android.os.StatFs._getBlockSize6723 = @__env.GetMethodIDNoThrow(global::android.os.StatFs.staticClass, "getBlockSize", "()I");
			global::android.os.StatFs._getBlockCount6724 = @__env.GetMethodIDNoThrow(global::android.os.StatFs.staticClass, "getBlockCount", "()I");
			global::android.os.StatFs._getFreeBlocks6725 = @__env.GetMethodIDNoThrow(global::android.os.StatFs.staticClass, "getFreeBlocks", "()I");
			global::android.os.StatFs._getAvailableBlocks6726 = @__env.GetMethodIDNoThrow(global::android.os.StatFs.staticClass, "getAvailableBlocks", "()I");
			global::android.os.StatFs._StatFs6727 = @__env.GetMethodIDNoThrow(global::android.os.StatFs.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
