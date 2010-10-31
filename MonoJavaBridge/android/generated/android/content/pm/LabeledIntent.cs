namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LabeledIntent : android.content.Intent
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LabeledIntent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.LabeledIntent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.pm.LabeledIntent._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void readFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.LabeledIntent.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V", ref global::android.content.pm.LabeledIntent._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.pm.LabeledIntent.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", ref global::android.content.pm.LabeledIntent._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.LabeledIntent.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", ref global::android.content.pm.LabeledIntent._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.drawable.Drawable;
		}
		public new int IconResource
		{
			get
			{
				return getIconResource();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getIconResource()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.LabeledIntent.staticClass, "getIconResource", "()I", ref global::android.content.pm.LabeledIntent._m4);
		}
		public new global::java.lang.String SourcePackage
		{
			get
			{
				return getSourcePackage();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String getSourcePackage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.LabeledIntent.staticClass, "getSourcePackage", "()Ljava/lang/String;", ref global::android.content.pm.LabeledIntent._m5) as java.lang.String;
		}
		public new int LabelResource
		{
			get
			{
				return getLabelResource();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getLabelResource()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.LabeledIntent.staticClass, "getLabelResource", "()I", ref global::android.content.pm.LabeledIntent._m6);
		}
		public new string NonLocalizedLabel
		{
			get
			{
				return getNonLocalizedLabel().toString();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.CharSequence getNonLocalizedLabel()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.pm.LabeledIntent.staticClass, "getNonLocalizedLabel", "()Ljava/lang/CharSequence;", ref global::android.content.pm.LabeledIntent._m7) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public LabeledIntent(android.content.Intent arg0, java.lang.String arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.LabeledIntent._m8.native == global::System.IntPtr.Zero)
				global::android.content.pm.LabeledIntent._m8 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Landroid/content/Intent;Ljava/lang/String;II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public LabeledIntent(android.content.Intent arg0, java.lang.String arg1, java.lang.CharSequence arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.LabeledIntent._m9.native == global::System.IntPtr.Zero)
				global::android.content.pm.LabeledIntent._m9 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Landroid/content/Intent;Ljava/lang/String;Ljava/lang/CharSequence;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public LabeledIntent(java.lang.String arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.LabeledIntent._m10.native == global::System.IntPtr.Zero)
				global::android.content.pm.LabeledIntent._m10 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Ljava/lang/String;II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public LabeledIntent(java.lang.String arg0, java.lang.CharSequence arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.LabeledIntent._m11.native == global::System.IntPtr.Zero)
				global::android.content.pm.LabeledIntent._m11 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/CharSequence;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2011;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.LabeledIntent.staticClass, _CREATOR2011)) as android.os.Parcelable_Creator;
			}
		}
		static LabeledIntent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.LabeledIntent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/LabeledIntent"));
			global::android.content.pm.LabeledIntent._CREATOR2011 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
