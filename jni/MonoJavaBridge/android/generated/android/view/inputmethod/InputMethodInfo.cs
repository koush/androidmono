namespace android.view.inputmethod
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class InputMethodInfo : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static InputMethodInfo()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.inputmethod.InputMethodInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.inputmethod.InputMethodInfo(@__env);
			}
		}
		internal InputMethodInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals9155;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputMethodInfo._equals9155, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._equals9155, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString9156;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.InputMethodInfo._toString9156));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._toString9156));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getId9157;
		public global::java.lang.String getId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.InputMethodInfo._getId9157));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._getId9157));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackageName9158;
		public global::java.lang.String getPackageName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.InputMethodInfo._getPackageName9158));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._getPackageName9158));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getComponent9159;
		public global::android.content.ComponentName getComponent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.InputMethodInfo._getComponent9159));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._getComponent9159));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dump9160;
		public void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.InputMethodInfo._dump9160, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._dump9160, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel9161;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.InputMethodInfo._writeToParcel9161, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._writeToParcel9161, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents9162;
		public int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.inputmethod.InputMethodInfo._describeContents9162);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._describeContents9162);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getServiceInfo9163;
		public global::android.content.pm.ServiceInfo getServiceInfo() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ServiceInfo>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.InputMethodInfo._getServiceInfo9163));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ServiceInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._getServiceInfo9163));
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadLabel9164;
		public global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.InputMethodInfo._loadLabel9164, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._loadLabel9164, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadIcon9165;
		public global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.InputMethodInfo._loadIcon9165, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._loadIcon9165, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getServiceName9166;
		public global::java.lang.String getServiceName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.InputMethodInfo._getServiceName9166));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._getServiceName9166));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSettingsActivity9167;
		public global::java.lang.String getSettingsActivity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.InputMethodInfo._getSettingsActivity9167));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._getSettingsActivity9167));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIsDefaultResourceId9168;
		public int getIsDefaultResourceId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.inputmethod.InputMethodInfo._getIsDefaultResourceId9168);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._getIsDefaultResourceId9168);
		}
		internal static global::net.sf.jni4net.jni.MethodId _InputMethodInfo9169;
		public InputMethodInfo(android.content.Context arg0, android.content.pm.ResolveInfo arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._InputMethodInfo9169, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _InputMethodInfo9170;
		public InputMethodInfo(java.lang.String arg0, java.lang.String arg1, java.lang.CharSequence arg2, java.lang.String arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._InputMethodInfo9170, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR9171;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.inputmethod.InputMethodInfo.staticClass = @__class;
			global::android.view.inputmethod.InputMethodInfo._equals9155 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.view.inputmethod.InputMethodInfo._toString9156 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.inputmethod.InputMethodInfo._getId9157 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "getId", "()Ljava/lang/String;");
			global::android.view.inputmethod.InputMethodInfo._getPackageName9158 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "getPackageName", "()Ljava/lang/String;");
			global::android.view.inputmethod.InputMethodInfo._getComponent9159 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "getComponent", "()Landroid/content/ComponentName;");
			global::android.view.inputmethod.InputMethodInfo._dump9160 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.view.inputmethod.InputMethodInfo._writeToParcel9161 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.inputmethod.InputMethodInfo._describeContents9162 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "describeContents", "()I");
			global::android.view.inputmethod.InputMethodInfo._getServiceInfo9163 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "getServiceInfo", "()Landroid/content/pm/ServiceInfo;");
			global::android.view.inputmethod.InputMethodInfo._loadLabel9164 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.view.inputmethod.InputMethodInfo._loadIcon9165 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;");
			global::android.view.inputmethod.InputMethodInfo._getServiceName9166 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "getServiceName", "()Ljava/lang/String;");
			global::android.view.inputmethod.InputMethodInfo._getSettingsActivity9167 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "getSettingsActivity", "()Ljava/lang/String;");
			global::android.view.inputmethod.InputMethodInfo._getIsDefaultResourceId9168 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "getIsDefaultResourceId", "()I");
			global::android.view.inputmethod.InputMethodInfo._InputMethodInfo9169 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "<init>", "(Landroid/content/Context;Landroid/content/pm/ResolveInfo;)V");
			global::android.view.inputmethod.InputMethodInfo._InputMethodInfo9170 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/CharSequence;Ljava/lang/String;)V");
		}
	}
}
