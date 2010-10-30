namespace android.appwidget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AppWidgetProviderInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AppWidgetProviderInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString2389;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.appwidget.AppWidgetProviderInfo.staticClass, global::android.appwidget.AppWidgetProviderInfo._toString2389)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2390;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetProviderInfo.staticClass, global::android.appwidget.AppWidgetProviderInfo._writeToParcel2390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2391;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.appwidget.AppWidgetProviderInfo.staticClass, global::android.appwidget.AppWidgetProviderInfo._describeContents2391);
		}
		internal static global::MonoJavaBridge.MethodId _AppWidgetProviderInfo2392;
		public AppWidgetProviderInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.appwidget.AppWidgetProviderInfo.staticClass, global::android.appwidget.AppWidgetProviderInfo._AppWidgetProviderInfo2392);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AppWidgetProviderInfo2393;
		public AppWidgetProviderInfo(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.appwidget.AppWidgetProviderInfo.staticClass, global::android.appwidget.AppWidgetProviderInfo._AppWidgetProviderInfo2393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _provider2394;
		public global::android.content.ComponentName provider
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.GetObjectField(this.JvmHandle, _provider2394)) as android.content.ComponentName;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _minWidth2395;
		public int minWidth
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _minWidth2395);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _minHeight2396;
		public int minHeight
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _minHeight2396);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _updatePeriodMillis2397;
		public int updatePeriodMillis
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _updatePeriodMillis2397);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _initialLayout2398;
		public int initialLayout
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _initialLayout2398);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _configure2399;
		public global::android.content.ComponentName configure
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.GetObjectField(this.JvmHandle, _configure2399)) as android.content.ComponentName;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _label2400;
		public global::java.lang.String label
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _label2400)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _icon2401;
		public int icon
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _icon2401);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2402;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.appwidget.AppWidgetProviderInfo.staticClass, _CREATOR2402)) as android.os.Parcelable_Creator;
			}
		}
		static AppWidgetProviderInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.appwidget.AppWidgetProviderInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/appwidget/AppWidgetProviderInfo"));
			global::android.appwidget.AppWidgetProviderInfo._toString2389 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.appwidget.AppWidgetProviderInfo._writeToParcel2390 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.appwidget.AppWidgetProviderInfo._describeContents2391 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "describeContents", "()I");
			global::android.appwidget.AppWidgetProviderInfo._AppWidgetProviderInfo2392 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "<init>", "()V");
			global::android.appwidget.AppWidgetProviderInfo._AppWidgetProviderInfo2393 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.appwidget.AppWidgetProviderInfo._provider2394 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "provider", "Landroid/content/ComponentName;");
			global::android.appwidget.AppWidgetProviderInfo._minWidth2395 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "minWidth", "I");
			global::android.appwidget.AppWidgetProviderInfo._minHeight2396 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "minHeight", "I");
			global::android.appwidget.AppWidgetProviderInfo._updatePeriodMillis2397 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "updatePeriodMillis", "I");
			global::android.appwidget.AppWidgetProviderInfo._initialLayout2398 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "initialLayout", "I");
			global::android.appwidget.AppWidgetProviderInfo._configure2399 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "configure", "Landroid/content/ComponentName;");
			global::android.appwidget.AppWidgetProviderInfo._label2400 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "label", "Ljava/lang/String;");
			global::android.appwidget.AppWidgetProviderInfo._icon2401 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "icon", "I");
			global::android.appwidget.AppWidgetProviderInfo._CREATOR2402 = @__env.GetStaticFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
