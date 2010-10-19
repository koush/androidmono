namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class InputMethodInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InputMethodInfo()
		{
			InitJNI();
		}
		internal InputMethodInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals10755;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._equals10755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._equals10755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString10756;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._toString10756)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._toString10756)) as java.lang.String;
		}
		public new global::java.lang.String Id
		{
			get
			{
				return getId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getId10757;
		public global::java.lang.String getId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._getId10757)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._getId10757)) as java.lang.String;
		}
		public new global::java.lang.String PackageName
		{
			get
			{
				return getPackageName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackageName10758;
		public global::java.lang.String getPackageName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._getPackageName10758)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._getPackageName10758)) as java.lang.String;
		}
		public new global::android.content.ComponentName Component
		{
			get
			{
				return getComponent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getComponent10759;
		public global::android.content.ComponentName getComponent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._getComponent10759)) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._getComponent10759)) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _dump10760;
		public void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._dump10760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._dump10760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel10761;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._writeToParcel10761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._writeToParcel10761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents10762;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._describeContents10762);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._describeContents10762);
		}
		public new global::android.content.pm.ServiceInfo ServiceInfo
		{
			get
			{
				return getServiceInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getServiceInfo10763;
		public global::android.content.pm.ServiceInfo getServiceInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._getServiceInfo10763)) as android.content.pm.ServiceInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._getServiceInfo10763)) as android.content.pm.ServiceInfo;
		}
		internal static global::MonoJavaBridge.MethodId _loadLabel10764;
		public global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._loadLabel10764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._loadLabel10764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _loadIcon10765;
		public global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._loadIcon10765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._loadIcon10765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		public new global::java.lang.String ServiceName
		{
			get
			{
				return getServiceName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getServiceName10766;
		public global::java.lang.String getServiceName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._getServiceName10766)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._getServiceName10766)) as java.lang.String;
		}
		public new global::java.lang.String SettingsActivity
		{
			get
			{
				return getSettingsActivity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSettingsActivity10767;
		public global::java.lang.String getSettingsActivity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._getSettingsActivity10767)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._getSettingsActivity10767)) as java.lang.String;
		}
		public new int IsDefaultResourceId
		{
			get
			{
				return getIsDefaultResourceId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIsDefaultResourceId10768;
		public int getIsDefaultResourceId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._getIsDefaultResourceId10768);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._getIsDefaultResourceId10768);
		}
		internal static global::MonoJavaBridge.MethodId _InputMethodInfo10769;
		public InputMethodInfo(android.content.Context arg0, android.content.pm.ResolveInfo arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._InputMethodInfo10769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InputMethodInfo10770;
		public InputMethodInfo(java.lang.String arg0, java.lang.String arg1, java.lang.CharSequence arg2, java.lang.String arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._InputMethodInfo10770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR10771;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputMethodInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputMethodInfo"));
			global::android.view.inputmethod.InputMethodInfo._equals10755 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.view.inputmethod.InputMethodInfo._toString10756 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.inputmethod.InputMethodInfo._getId10757 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "getId", "()Ljava/lang/String;");
			global::android.view.inputmethod.InputMethodInfo._getPackageName10758 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "getPackageName", "()Ljava/lang/String;");
			global::android.view.inputmethod.InputMethodInfo._getComponent10759 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "getComponent", "()Landroid/content/ComponentName;");
			global::android.view.inputmethod.InputMethodInfo._dump10760 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.view.inputmethod.InputMethodInfo._writeToParcel10761 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.inputmethod.InputMethodInfo._describeContents10762 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "describeContents", "()I");
			global::android.view.inputmethod.InputMethodInfo._getServiceInfo10763 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "getServiceInfo", "()Landroid/content/pm/ServiceInfo;");
			global::android.view.inputmethod.InputMethodInfo._loadLabel10764 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.view.inputmethod.InputMethodInfo._loadIcon10765 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;");
			global::android.view.inputmethod.InputMethodInfo._getServiceName10766 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "getServiceName", "()Ljava/lang/String;");
			global::android.view.inputmethod.InputMethodInfo._getSettingsActivity10767 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "getSettingsActivity", "()Ljava/lang/String;");
			global::android.view.inputmethod.InputMethodInfo._getIsDefaultResourceId10768 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "getIsDefaultResourceId", "()I");
			global::android.view.inputmethod.InputMethodInfo._InputMethodInfo10769 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "<init>", "(Landroid/content/Context;Landroid/content/pm/ResolveInfo;)V");
			global::android.view.inputmethod.InputMethodInfo._InputMethodInfo10770 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/CharSequence;Ljava/lang/String;)V");
		}
	}
}
