namespace android.appwidget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AppWidgetProviderInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AppWidgetProviderInfo()
		{
			InitJNI();
		}
		protected AppWidgetProviderInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString2381;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.appwidget.AppWidgetProviderInfo._toString2381)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.appwidget.AppWidgetProviderInfo.staticClass, global::android.appwidget.AppWidgetProviderInfo._toString2381)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2382;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetProviderInfo._writeToParcel2382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetProviderInfo.staticClass, global::android.appwidget.AppWidgetProviderInfo._writeToParcel2382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2383;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.appwidget.AppWidgetProviderInfo._describeContents2383);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.appwidget.AppWidgetProviderInfo.staticClass, global::android.appwidget.AppWidgetProviderInfo._describeContents2383);
		}
		internal static global::MonoJavaBridge.MethodId _AppWidgetProviderInfo2384;
		public AppWidgetProviderInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.appwidget.AppWidgetProviderInfo.staticClass, global::android.appwidget.AppWidgetProviderInfo._AppWidgetProviderInfo2384);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AppWidgetProviderInfo2385;
		public AppWidgetProviderInfo(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.appwidget.AppWidgetProviderInfo.staticClass, global::android.appwidget.AppWidgetProviderInfo._AppWidgetProviderInfo2385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _provider2386;
		public global::android.content.ComponentName provider
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _provider2386)) as android.content.ComponentName;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _minWidth2387;
		public int minWidth
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _minWidth2387);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _minHeight2388;
		public int minHeight
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _minHeight2388);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _updatePeriodMillis2389;
		public int updatePeriodMillis
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _updatePeriodMillis2389);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _initialLayout2390;
		public int initialLayout
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _initialLayout2390);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _configure2391;
		public global::android.content.ComponentName configure
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _configure2391)) as android.content.ComponentName;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _label2392;
		public global::java.lang.String label
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _label2392)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _icon2393;
		public int icon
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _icon2393);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2394;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.appwidget.AppWidgetProviderInfo.staticClass, _CREATOR2394)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.appwidget.AppWidgetProviderInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/appwidget/AppWidgetProviderInfo"));
			global::android.appwidget.AppWidgetProviderInfo._toString2381 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.appwidget.AppWidgetProviderInfo._writeToParcel2382 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.appwidget.AppWidgetProviderInfo._describeContents2383 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "describeContents", "()I");
			global::android.appwidget.AppWidgetProviderInfo._AppWidgetProviderInfo2384 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "<init>", "()V");
			global::android.appwidget.AppWidgetProviderInfo._AppWidgetProviderInfo2385 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.appwidget.AppWidgetProviderInfo._provider2386 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "provider", "Landroid/content/ComponentName;");
			global::android.appwidget.AppWidgetProviderInfo._minWidth2387 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "minWidth", "I");
			global::android.appwidget.AppWidgetProviderInfo._minHeight2388 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "minHeight", "I");
			global::android.appwidget.AppWidgetProviderInfo._updatePeriodMillis2389 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "updatePeriodMillis", "I");
			global::android.appwidget.AppWidgetProviderInfo._initialLayout2390 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "initialLayout", "I");
			global::android.appwidget.AppWidgetProviderInfo._configure2391 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "configure", "Landroid/content/ComponentName;");
			global::android.appwidget.AppWidgetProviderInfo._label2392 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "label", "Ljava/lang/String;");
			global::android.appwidget.AppWidgetProviderInfo._icon2393 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "icon", "I");
			global::android.appwidget.AppWidgetProviderInfo._CREATOR2394 = @__env.GetStaticFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
