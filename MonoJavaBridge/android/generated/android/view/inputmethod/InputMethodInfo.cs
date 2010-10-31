namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class InputMethodInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal InputMethodInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.view.inputmethod.InputMethodInfo._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.view.inputmethod.InputMethodInfo._m1) as java.lang.String;
		}
		public new global::java.lang.String Id
		{
			get
			{
				return getId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public global::java.lang.String getId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "getId", "()Ljava/lang/String;", ref global::android.view.inputmethod.InputMethodInfo._m2) as java.lang.String;
		}
		public new global::java.lang.String PackageName
		{
			get
			{
				return getPackageName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.lang.String getPackageName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "getPackageName", "()Ljava/lang/String;", ref global::android.view.inputmethod.InputMethodInfo._m3) as java.lang.String;
		}
		public new global::android.content.ComponentName Component
		{
			get
			{
				return getComponent();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::android.content.ComponentName getComponent()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ComponentName>(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "getComponent", "()Landroid/content/ComponentName;", ref global::android.view.inputmethod.InputMethodInfo._m4) as android.content.ComponentName;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public void dump(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V", ref global::android.view.inputmethod.InputMethodInfo._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void dump(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dump((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.view.inputmethod.InputMethodInfo._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "describeContents", "()I", ref global::android.view.inputmethod.InputMethodInfo._m7);
		}
		public new global::android.content.pm.ServiceInfo ServiceInfo
		{
			get
			{
				return getServiceInfo();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public global::android.content.pm.ServiceInfo getServiceInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "getServiceInfo", "()Landroid/content/pm/ServiceInfo;", ref global::android.view.inputmethod.InputMethodInfo._m8) as android.content.pm.ServiceInfo;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", ref global::android.view.inputmethod.InputMethodInfo._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", ref global::android.view.inputmethod.InputMethodInfo._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.drawable.Drawable;
		}
		public new global::java.lang.String ServiceName
		{
			get
			{
				return getServiceName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public global::java.lang.String getServiceName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "getServiceName", "()Ljava/lang/String;", ref global::android.view.inputmethod.InputMethodInfo._m11) as java.lang.String;
		}
		public new global::java.lang.String SettingsActivity
		{
			get
			{
				return getSettingsActivity();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public global::java.lang.String getSettingsActivity()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "getSettingsActivity", "()Ljava/lang/String;", ref global::android.view.inputmethod.InputMethodInfo._m12) as java.lang.String;
		}
		public new int IsDefaultResourceId
		{
			get
			{
				return getIsDefaultResourceId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public int getIsDefaultResourceId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "getIsDefaultResourceId", "()I", ref global::android.view.inputmethod.InputMethodInfo._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public InputMethodInfo(android.content.Context arg0, android.content.pm.ResolveInfo arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.InputMethodInfo._m14.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.InputMethodInfo._m14 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "<init>", "(Landroid/content/Context;Landroid/content/pm/ResolveInfo;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public InputMethodInfo(java.lang.String arg0, java.lang.String arg1, java.lang.CharSequence arg2, java.lang.String arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.InputMethodInfo._m15.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.InputMethodInfo._m15 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/CharSequence;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR5960;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.inputmethod.InputMethodInfo.staticClass, _CREATOR5960)) as android.os.Parcelable_Creator;
			}
		}
		static InputMethodInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputMethodInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputMethodInfo"));
			global::android.view.inputmethod.InputMethodInfo._CREATOR5960 = @__env.GetStaticFieldIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
