namespace android.appwidget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AppWidgetProviderInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AppWidgetProviderInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.appwidget.AppWidgetProviderInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.appwidget.AppWidgetProviderInfo._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.appwidget.AppWidgetProviderInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.appwidget.AppWidgetProviderInfo._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.appwidget.AppWidgetProviderInfo.staticClass, "describeContents", "()I", ref global::android.appwidget.AppWidgetProviderInfo._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public AppWidgetProviderInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.appwidget.AppWidgetProviderInfo._m3.native == global::System.IntPtr.Zero)
				global::android.appwidget.AppWidgetProviderInfo._m3 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.appwidget.AppWidgetProviderInfo.staticClass, global::android.appwidget.AppWidgetProviderInfo._m3);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public AppWidgetProviderInfo(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.appwidget.AppWidgetProviderInfo._m4.native == global::System.IntPtr.Zero)
				global::android.appwidget.AppWidgetProviderInfo._m4 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.appwidget.AppWidgetProviderInfo.staticClass, global::android.appwidget.AppWidgetProviderInfo._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _provider1487;
		public global::android.content.ComponentName provider
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.GetObjectField(this.JvmHandle, _provider1487)) as android.content.ComponentName;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _minWidth1488;
		public int minWidth
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _minWidth1488);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _minHeight1489;
		public int minHeight
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _minHeight1489);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _updatePeriodMillis1490;
		public int updatePeriodMillis
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _updatePeriodMillis1490);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _initialLayout1491;
		public int initialLayout
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _initialLayout1491);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _configure1492;
		public global::android.content.ComponentName configure
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.GetObjectField(this.JvmHandle, _configure1492)) as android.content.ComponentName;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _label1493;
		public global::java.lang.String label
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _label1493)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _icon1494;
		public int icon
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _icon1494);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1495;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.appwidget.AppWidgetProviderInfo.staticClass, _CREATOR1495)) as android.os.Parcelable_Creator;
			}
		}
		static AppWidgetProviderInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.appwidget.AppWidgetProviderInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/appwidget/AppWidgetProviderInfo"));
			global::android.appwidget.AppWidgetProviderInfo._provider1487 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "provider", "Landroid/content/ComponentName;");
			global::android.appwidget.AppWidgetProviderInfo._minWidth1488 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "minWidth", "I");
			global::android.appwidget.AppWidgetProviderInfo._minHeight1489 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "minHeight", "I");
			global::android.appwidget.AppWidgetProviderInfo._updatePeriodMillis1490 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "updatePeriodMillis", "I");
			global::android.appwidget.AppWidgetProviderInfo._initialLayout1491 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "initialLayout", "I");
			global::android.appwidget.AppWidgetProviderInfo._configure1492 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "configure", "Landroid/content/ComponentName;");
			global::android.appwidget.AppWidgetProviderInfo._label1493 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "label", "Ljava/lang/String;");
			global::android.appwidget.AppWidgetProviderInfo._icon1494 = @__env.GetFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "icon", "I");
			global::android.appwidget.AppWidgetProviderInfo._CREATOR1495 = @__env.GetStaticFieldIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
