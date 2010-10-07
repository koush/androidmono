namespace android.os
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class StatFs : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static StatFs()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.StatFs), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.os.StatFs(@__env);
			}
		}
		protected StatFs(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _restat6448;
		public virtual void restat(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.StatFs._restat6448, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.StatFs.staticClass, global::android.os.StatFs._restat6448, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBlockSize6449;
		public virtual int getBlockSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.os.StatFs._getBlockSize6449);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.os.StatFs.staticClass, global::android.os.StatFs._getBlockSize6449);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBlockCount6450;
		public virtual int getBlockCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.os.StatFs._getBlockCount6450);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.os.StatFs.staticClass, global::android.os.StatFs._getBlockCount6450);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFreeBlocks6451;
		public virtual int getFreeBlocks() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.os.StatFs._getFreeBlocks6451);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.os.StatFs.staticClass, global::android.os.StatFs._getFreeBlocks6451);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAvailableBlocks6452;
		public virtual int getAvailableBlocks() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.os.StatFs._getAvailableBlocks6452);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.os.StatFs.staticClass, global::android.os.StatFs._getAvailableBlocks6452);
		}
		internal static global::net.sf.jni4net.jni.MethodId _StatFs6453;
		public StatFs(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.StatFs.staticClass, global::android.os.StatFs._StatFs6453, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.os.StatFs.staticClass = @__class;
			global::android.os.StatFs._restat6448 = @__env.GetMethodID(global::android.os.StatFs.staticClass, "restat", "(Ljava/lang/String;)V");
			global::android.os.StatFs._getBlockSize6449 = @__env.GetMethodID(global::android.os.StatFs.staticClass, "getBlockSize", "()I");
			global::android.os.StatFs._getBlockCount6450 = @__env.GetMethodID(global::android.os.StatFs.staticClass, "getBlockCount", "()I");
			global::android.os.StatFs._getFreeBlocks6451 = @__env.GetMethodID(global::android.os.StatFs.staticClass, "getFreeBlocks", "()I");
			global::android.os.StatFs._getAvailableBlocks6452 = @__env.GetMethodID(global::android.os.StatFs.staticClass, "getAvailableBlocks", "()I");
			global::android.os.StatFs._StatFs6453 = @__env.GetMethodID(global::android.os.StatFs.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
