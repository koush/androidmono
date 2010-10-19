namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ComponentInfo : android.content.pm.PackageItemInfo
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ComponentInfo()
		{
			InitJNI();
		}
		protected ComponentInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1880;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ComponentInfo._writeToParcel1880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._writeToParcel1880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _loadLabel1881;
		public override global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ComponentInfo._loadLabel1881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._loadLabel1881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _dumpFront1882;
		protected override void dumpFront(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ComponentInfo._dumpFront1882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._dumpFront1882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dumpBack1883;
		protected override void dumpBack(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ComponentInfo._dumpBack1883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._dumpBack1883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int IconResource
		{
			get
			{
				return getIconResource();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIconResource1884;
		public virtual int getIconResource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ComponentInfo._getIconResource1884);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._getIconResource1884);
		}
		internal static global::MonoJavaBridge.MethodId _ComponentInfo1885;
		public ComponentInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._ComponentInfo1885);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ComponentInfo1886;
		public ComponentInfo(android.content.pm.ComponentInfo arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._ComponentInfo1886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ComponentInfo1887;
		protected ComponentInfo(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._ComponentInfo1887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _applicationInfo1888;
		public global::android.content.pm.ApplicationInfo applicationInfo
		{
			get
			{
				return default(global::android.content.pm.ApplicationInfo);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _processName1889;
		public global::java.lang.String processName
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _descriptionRes1890;
		public int descriptionRes
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _enabled1891;
		public bool enabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _exported1892;
		public bool exported
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.ComponentInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ComponentInfo"));
			global::android.content.pm.ComponentInfo._writeToParcel1880 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ComponentInfo._loadLabel1881 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.content.pm.ComponentInfo._dumpFront1882 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "dumpFront", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.ComponentInfo._dumpBack1883 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "dumpBack", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.ComponentInfo._getIconResource1884 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "getIconResource", "()I");
			global::android.content.pm.ComponentInfo._ComponentInfo1885 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "<init>", "()V");
			global::android.content.pm.ComponentInfo._ComponentInfo1886 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "<init>", "(Landroid/content/pm/ComponentInfo;)V");
			global::android.content.pm.ComponentInfo._ComponentInfo1887 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
