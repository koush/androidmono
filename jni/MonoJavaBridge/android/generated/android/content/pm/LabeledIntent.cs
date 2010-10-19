namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LabeledIntent : android.content.Intent
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LabeledIntent()
		{
			InitJNI();
		}
		protected LabeledIntent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1927;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.LabeledIntent._writeToParcel1927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._writeToParcel1927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readFromParcel1928;
		public override void readFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.LabeledIntent._readFromParcel1928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._readFromParcel1928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _loadLabel1929;
		public virtual global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.LabeledIntent._loadLabel1929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._loadLabel1929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _loadIcon1930;
		public virtual global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.LabeledIntent._loadIcon1930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._loadIcon1930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		public new int IconResource
		{
			get
			{
				return getIconResource();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIconResource1931;
		public virtual int getIconResource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.LabeledIntent._getIconResource1931);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._getIconResource1931);
		}
		public new global::java.lang.String SourcePackage
		{
			get
			{
				return getSourcePackage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSourcePackage1932;
		public virtual global::java.lang.String getSourcePackage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.LabeledIntent._getSourcePackage1932)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._getSourcePackage1932)) as java.lang.String;
		}
		public new int LabelResource
		{
			get
			{
				return getLabelResource();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLabelResource1933;
		public virtual int getLabelResource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.LabeledIntent._getLabelResource1933);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._getLabelResource1933);
		}
		public new string NonLocalizedLabel
		{
			get
			{
				return getNonLocalizedLabel().toString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNonLocalizedLabel1934;
		public virtual global::java.lang.CharSequence getNonLocalizedLabel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.LabeledIntent._getNonLocalizedLabel1934)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._getNonLocalizedLabel1934)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _LabeledIntent1935;
		public LabeledIntent(android.content.Intent arg0, java.lang.String arg1, int arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._LabeledIntent1935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LabeledIntent1936;
		public LabeledIntent(android.content.Intent arg0, java.lang.String arg1, java.lang.CharSequence arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._LabeledIntent1936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LabeledIntent1937;
		public LabeledIntent(java.lang.String arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._LabeledIntent1937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LabeledIntent1938;
		public LabeledIntent(java.lang.String arg0, java.lang.CharSequence arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._LabeledIntent1938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1939;
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
			global::android.content.pm.LabeledIntent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/LabeledIntent"));
			global::android.content.pm.LabeledIntent._writeToParcel1927 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.LabeledIntent._readFromParcel1928 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.content.pm.LabeledIntent._loadLabel1929 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.content.pm.LabeledIntent._loadIcon1930 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.LabeledIntent._getIconResource1931 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "getIconResource", "()I");
			global::android.content.pm.LabeledIntent._getSourcePackage1932 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "getSourcePackage", "()Ljava/lang/String;");
			global::android.content.pm.LabeledIntent._getLabelResource1933 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "getLabelResource", "()I");
			global::android.content.pm.LabeledIntent._getNonLocalizedLabel1934 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "getNonLocalizedLabel", "()Ljava/lang/CharSequence;");
			global::android.content.pm.LabeledIntent._LabeledIntent1935 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Landroid/content/Intent;Ljava/lang/String;II)V");
			global::android.content.pm.LabeledIntent._LabeledIntent1936 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Landroid/content/Intent;Ljava/lang/String;Ljava/lang/CharSequence;I)V");
			global::android.content.pm.LabeledIntent._LabeledIntent1937 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Ljava/lang/String;II)V");
			global::android.content.pm.LabeledIntent._LabeledIntent1938 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/CharSequence;I)V");
		}
	}
}
