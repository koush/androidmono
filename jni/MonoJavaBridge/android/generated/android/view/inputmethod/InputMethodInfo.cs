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
		internal static global::MonoJavaBridge.MethodId _equals15846;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._equals15846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._equals15846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString15847;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._toString15847)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._toString15847)) as java.lang.String;
		}
		public new global::java.lang.String Id
		{
			get
			{
				return getId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getId15848;
		public global::java.lang.String getId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._getId15848)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._getId15848)) as java.lang.String;
		}
		public new global::java.lang.String PackageName
		{
			get
			{
				return getPackageName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackageName15849;
		public global::java.lang.String getPackageName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._getPackageName15849)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._getPackageName15849)) as java.lang.String;
		}
		public new global::android.content.ComponentName Component
		{
			get
			{
				return getComponent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getComponent15850;
		public global::android.content.ComponentName getComponent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._getComponent15850)) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._getComponent15850)) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _dump15851;
		public void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._dump15851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._dump15851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel15852;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._writeToParcel15852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._writeToParcel15852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents15853;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._describeContents15853);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._describeContents15853);
		}
		public new global::android.content.pm.ServiceInfo ServiceInfo
		{
			get
			{
				return getServiceInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getServiceInfo15854;
		public global::android.content.pm.ServiceInfo getServiceInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._getServiceInfo15854)) as android.content.pm.ServiceInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._getServiceInfo15854)) as android.content.pm.ServiceInfo;
		}
		internal static global::MonoJavaBridge.MethodId _loadLabel15855;
		public global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._loadLabel15855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._loadLabel15855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _loadIcon15856;
		public global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._loadIcon15856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._loadIcon15856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		public new global::java.lang.String ServiceName
		{
			get
			{
				return getServiceName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getServiceName15857;
		public global::java.lang.String getServiceName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._getServiceName15857)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._getServiceName15857)) as java.lang.String;
		}
		public new global::java.lang.String SettingsActivity
		{
			get
			{
				return getSettingsActivity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSettingsActivity15858;
		public global::java.lang.String getSettingsActivity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._getSettingsActivity15858)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._getSettingsActivity15858)) as java.lang.String;
		}
		public new int IsDefaultResourceId
		{
			get
			{
				return getIsDefaultResourceId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIsDefaultResourceId15859;
		public int getIsDefaultResourceId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo._getIsDefaultResourceId15859);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._getIsDefaultResourceId15859);
		}
		internal static global::MonoJavaBridge.MethodId _InputMethodInfo15860;
		public InputMethodInfo(android.content.Context arg0, android.content.pm.ResolveInfo arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._InputMethodInfo15860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InputMethodInfo15861;
		public InputMethodInfo(java.lang.String arg0, java.lang.String arg1, java.lang.CharSequence arg2, java.lang.String arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._InputMethodInfo15861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR15862;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.inputmethod.InputMethodInfo.staticClass, _CREATOR15862)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputMethodInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputMethodInfo"));
			global::android.view.inputmethod.InputMethodInfo._equals15846 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.view.inputmethod.InputMethodInfo._toString15847 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.inputmethod.InputMethodInfo._getId15848 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "getId", "()Ljava/lang/String;");
			global::android.view.inputmethod.InputMethodInfo._getPackageName15849 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "getPackageName", "()Ljava/lang/String;");
			global::android.view.inputmethod.InputMethodInfo._getComponent15850 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "getComponent", "()Landroid/content/ComponentName;");
			global::android.view.inputmethod.InputMethodInfo._dump15851 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.view.inputmethod.InputMethodInfo._writeToParcel15852 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.inputmethod.InputMethodInfo._describeContents15853 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "describeContents", "()I");
			global::android.view.inputmethod.InputMethodInfo._getServiceInfo15854 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "getServiceInfo", "()Landroid/content/pm/ServiceInfo;");
			global::android.view.inputmethod.InputMethodInfo._loadLabel15855 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.view.inputmethod.InputMethodInfo._loadIcon15856 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;");
			global::android.view.inputmethod.InputMethodInfo._getServiceName15857 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "getServiceName", "()Ljava/lang/String;");
			global::android.view.inputmethod.InputMethodInfo._getSettingsActivity15858 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "getSettingsActivity", "()Ljava/lang/String;");
			global::android.view.inputmethod.InputMethodInfo._getIsDefaultResourceId15859 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "getIsDefaultResourceId", "()I");
			global::android.view.inputmethod.InputMethodInfo._InputMethodInfo15860 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "<init>", "(Landroid/content/Context;Landroid/content/pm/ResolveInfo;)V");
			global::android.view.inputmethod.InputMethodInfo._InputMethodInfo15861 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/CharSequence;Ljava/lang/String;)V");
			global::android.view.inputmethod.InputMethodInfo._CREATOR15862 = @__env.GetStaticFieldIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
