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
		internal static global::MonoJavaBridge.MethodId _toString993;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.appwidget.AppWidgetProviderInfo._toString993)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.appwidget.AppWidgetProviderInfo.staticClass, global::android.appwidget.AppWidgetProviderInfo._toString993)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel994;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetProviderInfo._writeToParcel994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetProviderInfo.staticClass, global::android.appwidget.AppWidgetProviderInfo._writeToParcel994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents995;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.appwidget.AppWidgetProviderInfo._describeContents995);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.appwidget.AppWidgetProviderInfo.staticClass, global::android.appwidget.AppWidgetProviderInfo._describeContents995);
		}
		internal static global::MonoJavaBridge.MethodId _AppWidgetProviderInfo996;
		public AppWidgetProviderInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.appwidget.AppWidgetProviderInfo.staticClass, global::android.appwidget.AppWidgetProviderInfo._AppWidgetProviderInfo996);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AppWidgetProviderInfo997;
		public AppWidgetProviderInfo(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.appwidget.AppWidgetProviderInfo.staticClass, global::android.appwidget.AppWidgetProviderInfo._AppWidgetProviderInfo997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _provider998;
		public global::android.content.ComponentName provider
		{
			get
			{
				return default(global::android.content.ComponentName);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _minWidth999;
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
		internal static global::MonoJavaBridge.FieldId _minHeight1000;
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
		internal static global::MonoJavaBridge.FieldId _updatePeriodMillis1001;
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
		internal static global::MonoJavaBridge.FieldId _initialLayout1002;
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
		internal static global::MonoJavaBridge.FieldId _configure1003;
		public global::android.content.ComponentName configure
		{
			get
			{
				return default(global::android.content.ComponentName);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _label1004;
		public global::java.lang.String label
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _icon1005;
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
		internal static global::MonoJavaBridge.FieldId _CREATOR1006;
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
			global::android.appwidget.AppWidgetProviderInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/appwidget/AppWidgetProviderInfo"));
			global::android.appwidget.AppWidgetProviderInfo._toString993 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.appwidget.AppWidgetProviderInfo._writeToParcel994 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.appwidget.AppWidgetProviderInfo._describeContents995 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "describeContents", "()I");
			global::android.appwidget.AppWidgetProviderInfo._AppWidgetProviderInfo996 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "<init>", "()V");
			global::android.appwidget.AppWidgetProviderInfo._AppWidgetProviderInfo997 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetProviderInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
