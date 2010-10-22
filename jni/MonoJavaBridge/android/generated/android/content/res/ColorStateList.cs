namespace android.content.res
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ColorStateList : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ColorStateList()
		{
			InitJNI();
		}
		protected ColorStateList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString4099;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.ColorStateList._toString4099)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._toString4099)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf4100;
		public static global::android.content.res.ColorStateList valueOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._valueOf4100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel4101;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.ColorStateList._writeToParcel4101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._writeToParcel4101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents4102;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.ColorStateList._describeContents4102);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._describeContents4102);
		}
		internal static global::MonoJavaBridge.MethodId _isStateful4103;
		public virtual bool isStateful() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.ColorStateList._isStateful4103);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._isStateful4103);
		}
		internal static global::MonoJavaBridge.MethodId _createFromXml4104;
		public static global::android.content.res.ColorStateList createFromXml(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._createFromXml4104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _withAlpha4105;
		public virtual global::android.content.res.ColorStateList withAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.ColorStateList._withAlpha4105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._withAlpha4105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _getColorForState4106;
		public virtual int getColorForState(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.ColorStateList._getColorForState4106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._getColorForState4106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int DefaultColor
		{
			get
			{
				return getDefaultColor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultColor4107;
		public virtual int getDefaultColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.ColorStateList._getDefaultColor4107);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._getDefaultColor4107);
		}
		internal static global::MonoJavaBridge.MethodId _ColorStateList4108;
		public ColorStateList(int[][] arg0, int[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._ColorStateList4108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR4109;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.res.ColorStateList.staticClass, _CREATOR4109)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.res.ColorStateList.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/ColorStateList"));
			global::android.content.res.ColorStateList._toString4099 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.res.ColorStateList._valueOf4100 = @__env.GetStaticMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "valueOf", "(I)Landroid/content/res/ColorStateList;");
			global::android.content.res.ColorStateList._writeToParcel4101 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.res.ColorStateList._describeContents4102 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "describeContents", "()I");
			global::android.content.res.ColorStateList._isStateful4103 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "isStateful", "()Z");
			global::android.content.res.ColorStateList._createFromXml4104 = @__env.GetStaticMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "createFromXml", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;)Landroid/content/res/ColorStateList;");
			global::android.content.res.ColorStateList._withAlpha4105 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "withAlpha", "(I)Landroid/content/res/ColorStateList;");
			global::android.content.res.ColorStateList._getColorForState4106 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "getColorForState", "([II)I");
			global::android.content.res.ColorStateList._getDefaultColor4107 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "getDefaultColor", "()I");
			global::android.content.res.ColorStateList._ColorStateList4108 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "<init>", "([[I[I)V");
			global::android.content.res.ColorStateList._CREATOR4109 = @__env.GetStaticFieldIDNoThrow(global::android.content.res.ColorStateList.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
