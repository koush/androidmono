namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ComponentInfo : android.content.pm.PackageItemInfo
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ComponentInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3688;
		public override void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._writeToParcel3688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _loadLabel3689;
		public override global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._loadLabel3689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _dumpFront3690;
		protected override void dumpFront(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._dumpFront3690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected void dumpFront(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dumpFront((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _dumpBack3691;
		protected override void dumpBack(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._dumpBack3691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected void dumpBack(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dumpBack((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		public new int IconResource
		{
			get
			{
				return getIconResource();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIconResource3692;
		public virtual int getIconResource()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._getIconResource3692);
		}
		internal static global::MonoJavaBridge.MethodId _ComponentInfo3693;
		public ComponentInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._ComponentInfo3693);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ComponentInfo3694;
		public ComponentInfo(android.content.pm.ComponentInfo arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._ComponentInfo3694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ComponentInfo3695;
		protected ComponentInfo(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._ComponentInfo3695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _applicationInfo3696;
		public global::android.content.pm.ApplicationInfo applicationInfo
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _applicationInfo3696)) as android.content.pm.ApplicationInfo;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _processName3697;
		public global::java.lang.String processName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _processName3697)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _descriptionRes3698;
		public int descriptionRes
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _descriptionRes3698);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _enabled3699;
		public bool enabled
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _enabled3699);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _exported3700;
		public bool exported
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _exported3700);
			}
			set
			{
			}
		}
		static ComponentInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.ComponentInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ComponentInfo"));
			global::android.content.pm.ComponentInfo._writeToParcel3688 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ComponentInfo._loadLabel3689 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.content.pm.ComponentInfo._dumpFront3690 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "dumpFront", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.ComponentInfo._dumpBack3691 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "dumpBack", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.ComponentInfo._getIconResource3692 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "getIconResource", "()I");
			global::android.content.pm.ComponentInfo._ComponentInfo3693 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "<init>", "()V");
			global::android.content.pm.ComponentInfo._ComponentInfo3694 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "<init>", "(Landroid/content/pm/ComponentInfo;)V");
			global::android.content.pm.ComponentInfo._ComponentInfo3695 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.content.pm.ComponentInfo._applicationInfo3696 = @__env.GetFieldIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "applicationInfo", "Landroid/content/pm/ApplicationInfo;");
			global::android.content.pm.ComponentInfo._processName3697 = @__env.GetFieldIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "processName", "Ljava/lang/String;");
			global::android.content.pm.ComponentInfo._descriptionRes3698 = @__env.GetFieldIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "descriptionRes", "I");
			global::android.content.pm.ComponentInfo._enabled3699 = @__env.GetFieldIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "enabled", "Z");
			global::android.content.pm.ComponentInfo._exported3700 = @__env.GetFieldIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "exported", "Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
