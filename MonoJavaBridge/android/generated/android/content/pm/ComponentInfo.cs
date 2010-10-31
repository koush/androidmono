namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ComponentInfo : android.content.pm.PackageItemInfo
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ComponentInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.ComponentInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.pm.ComponentInfo._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.pm.ComponentInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", ref global::android.content.pm.ComponentInfo._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void dumpFront(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.ComponentInfo.staticClass, "dumpFront", "(Landroid/util/Printer;Ljava/lang/String;)V", ref global::android.content.pm.ComponentInfo._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected void dumpFront(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dumpFront((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override void dumpBack(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.ComponentInfo.staticClass, "dumpBack", "(Landroid/util/Printer;Ljava/lang/String;)V", ref global::android.content.pm.ComponentInfo._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getIconResource()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.ComponentInfo.staticClass, "getIconResource", "()I", ref global::android.content.pm.ComponentInfo._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public ComponentInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.ComponentInfo._m5.native == global::System.IntPtr.Zero)
				global::android.content.pm.ComponentInfo._m5 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._m5);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public ComponentInfo(android.content.pm.ComponentInfo arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.ComponentInfo._m6.native == global::System.IntPtr.Zero)
				global::android.content.pm.ComponentInfo._m6 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "<init>", "(Landroid/content/pm/ComponentInfo;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected ComponentInfo(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.ComponentInfo._m7.native == global::System.IntPtr.Zero)
				global::android.content.pm.ComponentInfo._m7 = @__env.GetMethodIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _applicationInfo1984;
		public global::android.content.pm.ApplicationInfo applicationInfo
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _applicationInfo1984)) as android.content.pm.ApplicationInfo;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _processName1985;
		public global::java.lang.String processName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _processName1985)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _descriptionRes1986;
		public int descriptionRes
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _descriptionRes1986);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _enabled1987;
		public bool enabled
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _enabled1987);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _exported1988;
		public bool exported
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _exported1988);
			}
			set
			{
			}
		}
		static ComponentInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.ComponentInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ComponentInfo"));
			global::android.content.pm.ComponentInfo._applicationInfo1984 = @__env.GetFieldIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "applicationInfo", "Landroid/content/pm/ApplicationInfo;");
			global::android.content.pm.ComponentInfo._processName1985 = @__env.GetFieldIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "processName", "Ljava/lang/String;");
			global::android.content.pm.ComponentInfo._descriptionRes1986 = @__env.GetFieldIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "descriptionRes", "I");
			global::android.content.pm.ComponentInfo._enabled1987 = @__env.GetFieldIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "enabled", "Z");
			global::android.content.pm.ComponentInfo._exported1988 = @__env.GetFieldIDNoThrow(global::android.content.pm.ComponentInfo.staticClass, "exported", "Z");
		}
	}
}
