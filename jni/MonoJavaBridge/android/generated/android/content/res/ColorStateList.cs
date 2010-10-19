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
		internal static global::MonoJavaBridge.MethodId _toString2245;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.ColorStateList._toString2245)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._toString2245)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf2246;
		public static global::android.content.res.ColorStateList valueOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._valueOf2246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2247;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.ColorStateList._writeToParcel2247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._writeToParcel2247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2248;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.ColorStateList._describeContents2248);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._describeContents2248);
		}
		internal static global::MonoJavaBridge.MethodId _isStateful2249;
		public virtual bool isStateful() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.ColorStateList._isStateful2249);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._isStateful2249);
		}
		internal static global::MonoJavaBridge.MethodId _createFromXml2250;
		public static global::android.content.res.ColorStateList createFromXml(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._createFromXml2250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _withAlpha2251;
		public virtual global::android.content.res.ColorStateList withAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.ColorStateList._withAlpha2251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._withAlpha2251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _getColorForState2252;
		public virtual int getColorForState(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.ColorStateList._getColorForState2252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._getColorForState2252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int DefaultColor
		{
			get
			{
				return getDefaultColor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultColor2253;
		public virtual int getDefaultColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.ColorStateList._getDefaultColor2253);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._getDefaultColor2253);
		}
		internal static global::MonoJavaBridge.MethodId _ColorStateList2254;
		public ColorStateList(int[][] arg0, int[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._ColorStateList2254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2255;
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
			global::android.content.res.ColorStateList.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/ColorStateList"));
			global::android.content.res.ColorStateList._toString2245 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.res.ColorStateList._valueOf2246 = @__env.GetStaticMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "valueOf", "(I)Landroid/content/res/ColorStateList;");
			global::android.content.res.ColorStateList._writeToParcel2247 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.res.ColorStateList._describeContents2248 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "describeContents", "()I");
			global::android.content.res.ColorStateList._isStateful2249 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "isStateful", "()Z");
			global::android.content.res.ColorStateList._createFromXml2250 = @__env.GetStaticMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "createFromXml", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;)Landroid/content/res/ColorStateList;");
			global::android.content.res.ColorStateList._withAlpha2251 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "withAlpha", "(I)Landroid/content/res/ColorStateList;");
			global::android.content.res.ColorStateList._getColorForState2252 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "getColorForState", "([II)I");
			global::android.content.res.ColorStateList._getDefaultColor2253 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "getDefaultColor", "()I");
			global::android.content.res.ColorStateList._ColorStateList2254 = @__env.GetMethodIDNoThrow(global::android.content.res.ColorStateList.staticClass, "<init>", "([[I[I)V");
		}
	}
}
