namespace android.content.res
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TypedArray : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TypedArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.TypedArray.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.res.TypedArray._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool getBoolean(int arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.res.TypedArray.staticClass, "getBoolean", "(IZ)Z", ref global::android.content.res.TypedArray._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getInt(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.TypedArray.staticClass, "getInt", "(II)I", ref global::android.content.res.TypedArray._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual float getFloat(int arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.content.res.TypedArray.staticClass, "getFloat", "(IF)F", ref global::android.content.res.TypedArray._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.TypedArray.staticClass, "length", "()I", ref global::android.content.res.TypedArray._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool getValue(int arg0, android.util.TypedValue arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.res.TypedArray.staticClass, "getValue", "(ILandroid/util/TypedValue;)Z", ref global::android.content.res.TypedArray._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.content.res.Resources Resources
		{
			get
			{
				return getResources();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::android.content.res.Resources getResources()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.TypedArray.staticClass, "getResources", "()Landroid/content/res/Resources;", ref global::android.content.res.TypedArray._m6) as android.content.res.Resources;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int getInteger(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.TypedArray.staticClass, "getInteger", "(II)I", ref global::android.content.res.TypedArray._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.lang.String getString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.TypedArray.staticClass, "getString", "(I)Ljava/lang/String;", ref global::android.content.res.TypedArray._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getIndex(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.TypedArray.staticClass, "getIndex", "(I)I", ref global::android.content.res.TypedArray._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.lang.CharSequence getText(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.res.TypedArray.staticClass, "getText", "(I)Ljava/lang/CharSequence;", ref global::android.content.res.TypedArray._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void recycle()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.TypedArray.staticClass, "recycle", "()V", ref global::android.content.res.TypedArray._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.lang.CharSequence[] getTextArray(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.CharSequence>(this, global::android.content.res.TypedArray.staticClass, "getTextArray", "(I)[Ljava/lang/CharSequence;", ref global::android.content.res.TypedArray._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence[];
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual float getDimension(int arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.content.res.TypedArray.staticClass, "getDimension", "(IF)F", ref global::android.content.res.TypedArray._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual int getDimensionPixelOffset(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.TypedArray.staticClass, "getDimensionPixelOffset", "(II)I", ref global::android.content.res.TypedArray._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual int getDimensionPixelSize(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.TypedArray.staticClass, "getDimensionPixelSize", "(II)I", ref global::android.content.res.TypedArray._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual float getFraction(int arg0, int arg1, int arg2, float arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.content.res.TypedArray.staticClass, "getFraction", "(IIIF)F", ref global::android.content.res.TypedArray._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::android.graphics.drawable.Drawable getDrawable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.TypedArray.staticClass, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;", ref global::android.content.res.TypedArray._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual int getColor(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.TypedArray.staticClass, "getColor", "(II)I", ref global::android.content.res.TypedArray._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual global::android.content.res.ColorStateList getColorStateList(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.TypedArray.staticClass, "getColorStateList", "(I)Landroid/content/res/ColorStateList;", ref global::android.content.res.TypedArray._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.ColorStateList;
		}
		public new global::java.lang.String PositionDescription
		{
			get
			{
				return getPositionDescription();
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::java.lang.String getPositionDescription()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.TypedArray.staticClass, "getPositionDescription", "()Ljava/lang/String;", ref global::android.content.res.TypedArray._m20) as java.lang.String;
		}
		public new int IndexCount
		{
			get
			{
				return getIndexCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual int getIndexCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.TypedArray.staticClass, "getIndexCount", "()I", ref global::android.content.res.TypedArray._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual global::java.lang.String getNonResourceString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.TypedArray.staticClass, "getNonResourceString", "(I)Ljava/lang/String;", ref global::android.content.res.TypedArray._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual int getLayoutDimension(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.TypedArray.staticClass, "getLayoutDimension", "(II)I", ref global::android.content.res.TypedArray._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual int getLayoutDimension(int arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.TypedArray.staticClass, "getLayoutDimension", "(ILjava/lang/String;)I", ref global::android.content.res.TypedArray._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual int getResourceId(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.TypedArray.staticClass, "getResourceId", "(II)I", ref global::android.content.res.TypedArray._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual bool hasValue(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.res.TypedArray.staticClass, "hasValue", "(I)Z", ref global::android.content.res.TypedArray._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual global::android.util.TypedValue peekValue(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.TypedArray.staticClass, "peekValue", "(I)Landroid/util/TypedValue;", ref global::android.content.res.TypedArray._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.util.TypedValue;
		}
		static TypedArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.res.TypedArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/TypedArray"));
		}
	}
}
