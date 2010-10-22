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
		internal static global::MonoJavaBridge.MethodId _writeToParcel3671;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ComponentInfo._writeToParcel3671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._writeToParcel3671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _loadLabel3672;
		public override global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ComponentInfo._loadLabel3672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._loadLabel3672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _dumpFront3673;
		protected override void dumpFront(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ComponentInfo._dumpFront3673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._dumpFront3673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dumpBack3674;
		protected override void dumpBack(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ComponentInfo._dumpBack3674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._dumpBack3674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int IconResource
		{
			get
			{
				return getIconResource();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIconResource3675;
		public virtual int getIconResource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ComponentInfo._getIconResource3675);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._getIconResource3675);
		}
		internal static global::MonoJavaBridge.MethodId _ComponentInfo3676;
		public ComponentInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._ComponentInfo3676);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ComponentInfo3677;
		public ComponentInfo(android.content.pm.ComponentInfo arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._ComponentInfo3677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ComponentInfo3678;
		protected ComponentInfo(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._ComponentInfo3678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _applicationInfo3679;
		public global::android.content.pm.ApplicationInfo applicationInfo
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _applicationInfo3679)) as android.content.pm.ApplicationInfo;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _processName3680;
		public global::java.lang.String processName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _processName3680)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _descriptionRes3681;
		public int descriptionRes
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _descriptionRes3681);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _enabled3682;
		public bool enabled
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _enabled3682);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _exported3683;
		public bool exported
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _exported3683);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.ComponentInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ComponentInfo"));
			global::android.content.pm.ComponentInfo._writeToParcel3671 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ComponentInfo._loadLabel3672 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.content.pm.ComponentInfo._dumpFront3673 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "dumpFront", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.ComponentInfo._dumpBack3674 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "dumpBack", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.ComponentInfo._getIconResource3675 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "getIconResource", "()I");
			global::android.content.pm.ComponentInfo._ComponentInfo3676 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "<init>", "()V");
			global::android.content.pm.ComponentInfo._ComponentInfo3677 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "<init>", "(Landroid/content/pm/ComponentInfo;)V");
			global::android.content.pm.ComponentInfo._ComponentInfo3678 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.content.pm.ComponentInfo._applicationInfo3679 = @__env.GetFieldIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "applicationInfo", "Landroid/content/pm/ApplicationInfo;");
			global::android.content.pm.ComponentInfo._processName3680 = @__env.GetFieldIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "processName", "Ljava/lang/String;");
			global::android.content.pm.ComponentInfo._descriptionRes3681 = @__env.GetFieldIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "descriptionRes", "I");
			global::android.content.pm.ComponentInfo._enabled3682 = @__env.GetFieldIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "enabled", "Z");
			global::android.content.pm.ComponentInfo._exported3683 = @__env.GetFieldIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "exported", "Z");
		}
	}
}
