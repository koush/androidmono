namespace android.content.res
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ColorStateList : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ColorStateList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString4116;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.ColorStateList._toString4116)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._toString4116)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf4117;
		public static global::android.content.res.ColorStateList valueOf(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._valueOf4117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel4118;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.ColorStateList._writeToParcel4118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._writeToParcel4118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents4119;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.ColorStateList._describeContents4119);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._describeContents4119);
		}
		internal static global::MonoJavaBridge.MethodId _isStateful4120;
		public virtual bool isStateful()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.ColorStateList._isStateful4120);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._isStateful4120);
		}
		internal static global::MonoJavaBridge.MethodId _createFromXml4121;
		public static global::android.content.res.ColorStateList createFromXml(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._createFromXml4121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _withAlpha4122;
		public virtual global::android.content.res.ColorStateList withAlpha(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.ColorStateList._withAlpha4122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._withAlpha4122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _getColorForState4123;
		public virtual int getColorForState(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.ColorStateList._getColorForState4123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._getColorForState4123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int DefaultColor
		{
			get
			{
				return getDefaultColor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultColor4124;
		public virtual int getDefaultColor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.ColorStateList._getDefaultColor4124);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._getDefaultColor4124);
		}
		internal static global::MonoJavaBridge.MethodId _ColorStateList4125;
		public ColorStateList(int[][] arg0, int[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._ColorStateList4125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR4126;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.res.ColorStateList.staticClass, _CREATOR4126)) as android.os.Parcelable_Creator;
			}
		}
		static ColorStateList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.res.ColorStateList.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/ColorStateList"));
			global::android.content.res.ColorStateList._toString4116 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.res.ColorStateList._valueOf4117 = @__env.GetStaticMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "valueOf", "(I)Landroid/content/res/ColorStateList;");
			global::android.content.res.ColorStateList._writeToParcel4118 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.res.ColorStateList._describeContents4119 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "describeContents", "()I");
			global::android.content.res.ColorStateList._isStateful4120 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "isStateful", "()Z");
			global::android.content.res.ColorStateList._createFromXml4121 = @__env.GetStaticMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "createFromXml", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;)Landroid/content/res/ColorStateList;");
			global::android.content.res.ColorStateList._withAlpha4122 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "withAlpha", "(I)Landroid/content/res/ColorStateList;");
			global::android.content.res.ColorStateList._getColorForState4123 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "getColorForState", "([II)I");
			global::android.content.res.ColorStateList._getDefaultColor4124 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "getDefaultColor", "()I");
			global::android.content.res.ColorStateList._ColorStateList4125 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "<init>", "([[I[I)V");
			global::android.content.res.ColorStateList._CREATOR4126 = @__env.GetStaticFieldIDNoThrow(global::android.content.res.ColorStateList.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
