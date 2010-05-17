namespace android.view.inputmethod 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class InputMethodInfo : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static InputMethodInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.inputmethod.InputMethodInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _equals8483; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodInfo)) 
				return @__env.CallBooleanMethod(this, _equals8483, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputMethodInfo.staticClass, _equals8483, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString8484; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString8484)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.InputMethodInfo.staticClass, _toString8484)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getId8485; 
		public java.lang.String getId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getId8485)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.InputMethodInfo.staticClass, _getId8485)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPackageName8486; 
		public java.lang.String getPackageName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPackageName8486)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.InputMethodInfo.staticClass, _getPackageName8486)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getComponent8487; 
		public android.content.ComponentName getComponent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallObjectMethodPtr(this, _getComponent8487)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.InputMethodInfo.staticClass, _getComponent8487)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dump8488; 
		public void dump(android.util.Printer arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodInfo)) 
				@__env.CallVoidMethod(this, _dump8488, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodInfo.staticClass, _dump8488, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel8489; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodInfo)) 
				@__env.CallVoidMethod(this, _writeToParcel8489, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodInfo.staticClass, _writeToParcel8489, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents8490; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodInfo)) 
				return @__env.CallIntMethod(this, _describeContents8490); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.inputmethod.InputMethodInfo.staticClass, _describeContents8490); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getServiceInfo8491; 
		public android.content.pm.ServiceInfo getServiceInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ServiceInfo>(@__env, @__env.CallObjectMethodPtr(this, _getServiceInfo8491)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ServiceInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.InputMethodInfo.staticClass, _getServiceInfo8491)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadLabel8492; 
		public java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodInfo)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _loadLabel8492, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.InputMethodInfo.staticClass, _loadLabel8492, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadIcon8493; 
		public android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _loadIcon8493, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.InputMethodInfo.staticClass, _loadIcon8493, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getServiceName8494; 
		public java.lang.String getServiceName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getServiceName8494)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.InputMethodInfo.staticClass, _getServiceName8494)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSettingsActivity8495; 
		public java.lang.String getSettingsActivity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSettingsActivity8495)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.InputMethodInfo.staticClass, _getSettingsActivity8495)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIsDefaultResourceId8496; 
		public int getIsDefaultResourceId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodInfo)) 
				return @__env.CallIntMethod(this, _getIsDefaultResourceId8496); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.inputmethod.InputMethodInfo.staticClass, _getIsDefaultResourceId8496); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _InputMethodInfo8497; 
		public InputMethodInfo(android.content.Context arg0, android.content.pm.ResolveInfo arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.inputmethod.InputMethodInfo.staticClass, _InputMethodInfo8497, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _InputMethodInfo8498; 
		public InputMethodInfo(java.lang.String arg0, java.lang.String arg1, java.lang.CharSequence arg2, java.lang.String arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.inputmethod.InputMethodInfo.staticClass, _InputMethodInfo8498, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR8499; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.inputmethod.InputMethodInfo.staticClass = @__class; 
			global::android.view.inputmethod.InputMethodInfo._equals8483 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.view.inputmethod.InputMethodInfo._toString8484 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.view.inputmethod.InputMethodInfo._getId8485 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "getId", "()Ljava/lang/String;"); 
			global::android.view.inputmethod.InputMethodInfo._getPackageName8486 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "getPackageName", "()Ljava/lang/String;"); 
			global::android.view.inputmethod.InputMethodInfo._getComponent8487 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "getComponent", "()Landroid/content/ComponentName;"); 
			global::android.view.inputmethod.InputMethodInfo._dump8488 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V"); 
			global::android.view.inputmethod.InputMethodInfo._writeToParcel8489 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.view.inputmethod.InputMethodInfo._describeContents8490 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "describeContents", "()I"); 
			global::android.view.inputmethod.InputMethodInfo._getServiceInfo8491 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "getServiceInfo", "()Landroid/content/pm/ServiceInfo;"); 
			global::android.view.inputmethod.InputMethodInfo._loadLabel8492 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;"); 
			global::android.view.inputmethod.InputMethodInfo._loadIcon8493 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;"); 
			global::android.view.inputmethod.InputMethodInfo._getServiceName8494 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "getServiceName", "()Ljava/lang/String;"); 
			global::android.view.inputmethod.InputMethodInfo._getSettingsActivity8495 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "getSettingsActivity", "()Ljava/lang/String;"); 
			global::android.view.inputmethod.InputMethodInfo._getIsDefaultResourceId8496 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "getIsDefaultResourceId", "()I"); 
			global::android.view.inputmethod.InputMethodInfo._InputMethodInfo8497 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "<init>", "(Landroid/content/Context;Landroid/content/pm/ResolveInfo;)V"); 
			global::android.view.inputmethod.InputMethodInfo._InputMethodInfo8498 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodInfo.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/CharSequence;Ljava/lang/String;)V"); 
		} 
	} 
} 
