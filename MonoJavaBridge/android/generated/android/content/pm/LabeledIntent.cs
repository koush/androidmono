namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LabeledIntent : android.content.Intent
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LabeledIntent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3740;
		public override void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._writeToParcel3740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readFromParcel3741;
		public override void readFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._readFromParcel3741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _loadLabel3742;
		public virtual global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._loadLabel3742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _loadIcon3743;
		public virtual global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._loadIcon3743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		public new int IconResource
		{
			get
			{
				return getIconResource();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIconResource3744;
		public virtual int getIconResource()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._getIconResource3744);
		}
		public new global::java.lang.String SourcePackage
		{
			get
			{
				return getSourcePackage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSourcePackage3745;
		public virtual global::java.lang.String getSourcePackage()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._getSourcePackage3745)) as java.lang.String;
		}
		public new int LabelResource
		{
			get
			{
				return getLabelResource();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLabelResource3746;
		public virtual int getLabelResource()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._getLabelResource3746);
		}
		public new string NonLocalizedLabel
		{
			get
			{
				return getNonLocalizedLabel().toString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNonLocalizedLabel3747;
		public virtual global::java.lang.CharSequence getNonLocalizedLabel()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._getNonLocalizedLabel3747)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _LabeledIntent3748;
		public LabeledIntent(android.content.Intent arg0, java.lang.String arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._LabeledIntent3748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LabeledIntent3749;
		public LabeledIntent(android.content.Intent arg0, java.lang.String arg1, java.lang.CharSequence arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._LabeledIntent3749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LabeledIntent3750;
		public LabeledIntent(java.lang.String arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._LabeledIntent3750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LabeledIntent3751;
		public LabeledIntent(java.lang.String arg0, java.lang.CharSequence arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._LabeledIntent3751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3752;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.LabeledIntent.staticClass, _CREATOR3752)) as android.os.Parcelable_Creator;
			}
		}
		static LabeledIntent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.LabeledIntent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/LabeledIntent"));
			global::android.content.pm.LabeledIntent._writeToParcel3740 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.LabeledIntent._readFromParcel3741 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.content.pm.LabeledIntent._loadLabel3742 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.content.pm.LabeledIntent._loadIcon3743 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.LabeledIntent._getIconResource3744 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "getIconResource", "()I");
			global::android.content.pm.LabeledIntent._getSourcePackage3745 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "getSourcePackage", "()Ljava/lang/String;");
			global::android.content.pm.LabeledIntent._getLabelResource3746 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "getLabelResource", "()I");
			global::android.content.pm.LabeledIntent._getNonLocalizedLabel3747 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "getNonLocalizedLabel", "()Ljava/lang/CharSequence;");
			global::android.content.pm.LabeledIntent._LabeledIntent3748 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Landroid/content/Intent;Ljava/lang/String;II)V");
			global::android.content.pm.LabeledIntent._LabeledIntent3749 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Landroid/content/Intent;Ljava/lang/String;Ljava/lang/CharSequence;I)V");
			global::android.content.pm.LabeledIntent._LabeledIntent3750 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Ljava/lang/String;II)V");
			global::android.content.pm.LabeledIntent._LabeledIntent3751 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/CharSequence;I)V");
			global::android.content.pm.LabeledIntent._CREATOR3752 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
