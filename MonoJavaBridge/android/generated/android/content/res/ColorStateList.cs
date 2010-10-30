namespace android.content.res
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ColorStateList : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ColorStateList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.ColorStateList.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.res.ColorStateList._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::android.content.res.ColorStateList valueOf(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.ColorStateList._m1.native == global::System.IntPtr.Zero)
				global::android.content.res.ColorStateList._m1 = @__env.GetStaticMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "valueOf", "(I)Landroid/content/res/ColorStateList;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.ColorStateList;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.ColorStateList.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.res.ColorStateList._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.ColorStateList.staticClass, "describeContents", "()I", ref global::android.content.res.ColorStateList._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool isStateful()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.res.ColorStateList.staticClass, "isStateful", "()Z", ref global::android.content.res.ColorStateList._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::android.content.res.ColorStateList createFromXml(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.ColorStateList._m5.native == global::System.IntPtr.Zero)
				global::android.content.res.ColorStateList._m5 = @__env.GetStaticMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "createFromXml", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;)Landroid/content/res/ColorStateList;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.ColorStateList;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::android.content.res.ColorStateList withAlpha(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.ColorStateList.staticClass, "withAlpha", "(I)Landroid/content/res/ColorStateList;", ref global::android.content.res.ColorStateList._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.ColorStateList;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int getColorForState(int[] arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.ColorStateList.staticClass, "getColorForState", "([II)I", ref global::android.content.res.ColorStateList._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int DefaultColor
		{
			get
			{
				return getDefaultColor();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int getDefaultColor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.ColorStateList.staticClass, "getDefaultColor", "()I", ref global::android.content.res.ColorStateList._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public ColorStateList(int[][] arg0, int[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.ColorStateList._m9.native == global::System.IntPtr.Zero)
				global::android.content.res.ColorStateList._m9 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "<init>", "([[I[I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2135;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.res.ColorStateList.staticClass, _CREATOR2135)) as android.os.Parcelable_Creator;
			}
		}
		static ColorStateList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.res.ColorStateList.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/ColorStateList"));
			global::android.content.res.ColorStateList._CREATOR2135 = @__env.GetStaticFieldIDNoThrow(global::android.content.res.ColorStateList.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
