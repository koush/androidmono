namespace android.appwidget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AppWidgetProviderInfo : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static AppWidgetProviderInfo()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.appwidget.AppWidgetProviderInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _toString978;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.appwidget.AppWidgetProviderInfo._toString978));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.appwidget.AppWidgetProviderInfo.staticClass, global::android.appwidget.AppWidgetProviderInfo._toString978));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel979;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetProviderInfo._writeToParcel979, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetProviderInfo.staticClass, global::android.appwidget.AppWidgetProviderInfo._writeToParcel979, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents980;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.appwidget.AppWidgetProviderInfo._describeContents980);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.appwidget.AppWidgetProviderInfo.staticClass, global::android.appwidget.AppWidgetProviderInfo._describeContents980);
		}
		internal static global::net.sf.jni4net.jni.MethodId _AppWidgetProviderInfo981;
		public AppWidgetProviderInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.appwidget.AppWidgetProviderInfo.staticClass, global::android.appwidget.AppWidgetProviderInfo._AppWidgetProviderInfo981, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _AppWidgetProviderInfo982;
		public AppWidgetProviderInfo(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.appwidget.AppWidgetProviderInfo.staticClass, global::android.appwidget.AppWidgetProviderInfo._AppWidgetProviderInfo982, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _provider983;
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
		internal static global::net.sf.jni4net.jni.FieldId _minWidth984;
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
		internal static global::net.sf.jni4net.jni.FieldId _minHeight985;
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
		internal static global::net.sf.jni4net.jni.FieldId _updatePeriodMillis986;
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
		internal static global::net.sf.jni4net.jni.FieldId _initialLayout987;
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
		internal static global::net.sf.jni4net.jni.FieldId _configure988;
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
		internal static global::net.sf.jni4net.jni.FieldId _label989;
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
		internal static global::net.sf.jni4net.jni.FieldId _icon990;
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR991;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.appwidget.AppWidgetProviderInfo.staticClass = @__class;
			global::android.appwidget.AppWidgetProviderInfo._toString978 = @__env.GetMethodID(global::android.appwidget.AppWidgetProviderInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.appwidget.AppWidgetProviderInfo._writeToParcel979 = @__env.GetMethodID(global::android.appwidget.AppWidgetProviderInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.appwidget.AppWidgetProviderInfo._describeContents980 = @__env.GetMethodID(global::android.appwidget.AppWidgetProviderInfo.staticClass, "describeContents", "()I");
			global::android.appwidget.AppWidgetProviderInfo._AppWidgetProviderInfo981 = @__env.GetMethodID(global::android.appwidget.AppWidgetProviderInfo.staticClass, "<init>", "()V");
			global::android.appwidget.AppWidgetProviderInfo._AppWidgetProviderInfo982 = @__env.GetMethodID(global::android.appwidget.AppWidgetProviderInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
