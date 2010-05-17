namespace android.appwidget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AppWidgetProviderInfo : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static AppWidgetProviderInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.appwidget.AppWidgetProviderInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.appwidget.AppWidgetProviderInfo(@__env); 
			} 
		} 
		protected AppWidgetProviderInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString835; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetProviderInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString835)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.appwidget.AppWidgetProviderInfo.staticClass, _toString835)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel836; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetProviderInfo)) 
				@__env.CallVoidMethod(this, _writeToParcel836, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.appwidget.AppWidgetProviderInfo.staticClass, _writeToParcel836, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents837; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.appwidget.AppWidgetProviderInfo)) 
				return @__env.CallIntMethod(this, _describeContents837); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.appwidget.AppWidgetProviderInfo.staticClass, _describeContents837); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AppWidgetProviderInfo838; 
		public AppWidgetProviderInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.appwidget.AppWidgetProviderInfo.staticClass, _AppWidgetProviderInfo838, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AppWidgetProviderInfo839; 
		public AppWidgetProviderInfo(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.appwidget.AppWidgetProviderInfo.staticClass, _AppWidgetProviderInfo839, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _provider840; 
		public android.content.ComponentName provider
		{ 
			get 
			{ 
				return default(android.content.ComponentName); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _minWidth841; 
		public int minWidth
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _minHeight842; 
		public int minHeight
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _updatePeriodMillis843; 
		public int updatePeriodMillis
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _initialLayout844; 
		public int initialLayout
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _configure845; 
		public android.content.ComponentName configure
		{ 
			get 
			{ 
				return default(android.content.ComponentName); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _label846; 
		public java.lang.String label
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _icon847; 
		public int icon
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR848; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.appwidget.AppWidgetProviderInfo.staticClass = @__class; 
			global::android.appwidget.AppWidgetProviderInfo._toString835 = @__env.GetMethodID(global::android.appwidget.AppWidgetProviderInfo.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.appwidget.AppWidgetProviderInfo._writeToParcel836 = @__env.GetMethodID(global::android.appwidget.AppWidgetProviderInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.appwidget.AppWidgetProviderInfo._describeContents837 = @__env.GetMethodID(global::android.appwidget.AppWidgetProviderInfo.staticClass, "describeContents", "()I"); 
			global::android.appwidget.AppWidgetProviderInfo._AppWidgetProviderInfo838 = @__env.GetMethodID(global::android.appwidget.AppWidgetProviderInfo.staticClass, "<init>", "()V"); 
			global::android.appwidget.AppWidgetProviderInfo._AppWidgetProviderInfo839 = @__env.GetMethodID(global::android.appwidget.AppWidgetProviderInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
