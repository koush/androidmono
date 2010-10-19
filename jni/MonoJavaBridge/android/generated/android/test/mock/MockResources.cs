namespace android.test.mock
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MockResources : android.content.res.Resources
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MockResources()
		{
			InitJNI();
		}
		protected MockResources(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getValue8052;
		public override void getValue(int arg0, android.util.TypedValue arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockResources._getValue8052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getValue8052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getValue8053;
		public override void getValue(java.lang.String arg0, android.util.TypedValue arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockResources._getValue8053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getValue8053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getInteger8054;
		public override int getInteger(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockResources._getInteger8054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getInteger8054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getString8055;
		public override global::java.lang.String getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getString8055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getString8055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getString8056;
		public override global::java.lang.String getString(int arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getString8056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getString8056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getIdentifier8057;
		public override int getIdentifier(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockResources._getIdentifier8057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getIdentifier8057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getText8058;
		public override global::java.lang.CharSequence getText(int arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getText8058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getText8058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		public java.lang.CharSequence getText(int arg0, string arg1)
		{
			return getText(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _getText8059;
		public override global::java.lang.CharSequence getText(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getText8059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getText8059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getQuantityText8060;
		public override global::java.lang.CharSequence getQuantityText(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getQuantityText8060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getQuantityText8060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getQuantityString8061;
		public override global::java.lang.String getQuantityString(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getQuantityString8061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getQuantityString8061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getQuantityString8062;
		public override global::java.lang.String getQuantityString(int arg0, int arg1, java.lang.Object[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getQuantityString8062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getQuantityString8062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTextArray8063;
		public override global::java.lang.CharSequence[] getTextArray(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getTextArray8063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getTextArray8063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence[];
		}
		internal static global::MonoJavaBridge.MethodId _getStringArray8064;
		public override global::java.lang.String[] getStringArray(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getStringArray8064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getStringArray8064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getIntArray8065;
		public override int[] getIntArray(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getIntArray8065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getIntArray8065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _obtainTypedArray8066;
		public override global::android.content.res.TypedArray obtainTypedArray(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._obtainTypedArray8066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.TypedArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._obtainTypedArray8066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.TypedArray;
		}
		internal static global::MonoJavaBridge.MethodId _getDimension8067;
		public override float getDimension(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.test.mock.MockResources._getDimension8067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getDimension8067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDimensionPixelOffset8068;
		public override int getDimensionPixelOffset(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockResources._getDimensionPixelOffset8068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getDimensionPixelOffset8068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDimensionPixelSize8069;
		public override int getDimensionPixelSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockResources._getDimensionPixelSize8069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getDimensionPixelSize8069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable8070;
		public override global::android.graphics.drawable.Drawable getDrawable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getDrawable8070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getDrawable8070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getMovie8071;
		public override global::android.graphics.Movie getMovie(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getMovie8071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Movie;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getMovie8071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Movie;
		}
		internal static global::MonoJavaBridge.MethodId _getColor8072;
		public override int getColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockResources._getColor8072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getColor8072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColorStateList8073;
		public override global::android.content.res.ColorStateList getColorStateList(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getColorStateList8073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getColorStateList8073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _getLayout8074;
		public override global::android.content.res.XmlResourceParser getLayout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getLayout8074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.XmlResourceParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getLayout8074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.XmlResourceParser;
		}
		internal static global::MonoJavaBridge.MethodId _getAnimation8075;
		public override global::android.content.res.XmlResourceParser getAnimation(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getAnimation8075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.XmlResourceParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getAnimation8075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.XmlResourceParser;
		}
		internal static global::MonoJavaBridge.MethodId _getXml8076;
		public override global::android.content.res.XmlResourceParser getXml(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getXml8076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.XmlResourceParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getXml8076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.XmlResourceParser;
		}
		internal static global::MonoJavaBridge.MethodId _openRawResource8077;
		public override global::java.io.InputStream openRawResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._openRawResource8077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._openRawResource8077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _openRawResourceFd8078;
		public override global::android.content.res.AssetFileDescriptor openRawResourceFd(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._openRawResourceFd8078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.AssetFileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._openRawResourceFd8078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.AssetFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _obtainAttributes8079;
		public override global::android.content.res.TypedArray obtainAttributes(android.util.AttributeSet arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._obtainAttributes8079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.TypedArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._obtainAttributes8079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.TypedArray;
		}
		internal static global::MonoJavaBridge.MethodId _updateConfiguration8080;
		public override void updateConfiguration(android.content.res.Configuration arg0, android.util.DisplayMetrics arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockResources._updateConfiguration8080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._updateConfiguration8080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.util.DisplayMetrics DisplayMetrics
		{
			get
			{
				return getDisplayMetrics();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayMetrics8081;
		public override global::android.util.DisplayMetrics getDisplayMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getDisplayMetrics8081)) as android.util.DisplayMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getDisplayMetrics8081)) as android.util.DisplayMetrics;
		}
		public new global::android.content.res.Configuration Configuration
		{
			get
			{
				return getConfiguration();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConfiguration8082;
		public override global::android.content.res.Configuration getConfiguration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getConfiguration8082)) as android.content.res.Configuration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getConfiguration8082)) as android.content.res.Configuration;
		}
		internal static global::MonoJavaBridge.MethodId _getResourceName8083;
		public override global::java.lang.String getResourceName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getResourceName8083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getResourceName8083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getResourcePackageName8084;
		public override global::java.lang.String getResourcePackageName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getResourcePackageName8084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getResourcePackageName8084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getResourceTypeName8085;
		public override global::java.lang.String getResourceTypeName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getResourceTypeName8085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getResourceTypeName8085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getResourceEntryName8086;
		public override global::java.lang.String getResourceEntryName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getResourceEntryName8086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getResourceEntryName8086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _MockResources8087;
		public MockResources()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._MockResources8087);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.mock.MockResources.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/mock/MockResources"));
			global::android.test.mock.MockResources._getValue8052 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getValue", "(ILandroid/util/TypedValue;Z)V");
			global::android.test.mock.MockResources._getValue8053 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getValue", "(Ljava/lang/String;Landroid/util/TypedValue;Z)V");
			global::android.test.mock.MockResources._getInteger8054 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getInteger", "(I)I");
			global::android.test.mock.MockResources._getString8055 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.test.mock.MockResources._getString8056 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getString", "(I[Ljava/lang/Object;)Ljava/lang/String;");
			global::android.test.mock.MockResources._getIdentifier8057 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getIdentifier", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I");
			global::android.test.mock.MockResources._getText8058 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getText", "(ILjava/lang/CharSequence;)Ljava/lang/CharSequence;");
			global::android.test.mock.MockResources._getText8059 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getText", "(I)Ljava/lang/CharSequence;");
			global::android.test.mock.MockResources._getQuantityText8060 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getQuantityText", "(II)Ljava/lang/CharSequence;");
			global::android.test.mock.MockResources._getQuantityString8061 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getQuantityString", "(II)Ljava/lang/String;");
			global::android.test.mock.MockResources._getQuantityString8062 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getQuantityString", "(II[Ljava/lang/Object;)Ljava/lang/String;");
			global::android.test.mock.MockResources._getTextArray8063 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getTextArray", "(I)[Ljava/lang/CharSequence;");
			global::android.test.mock.MockResources._getStringArray8064 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getStringArray", "(I)[Ljava/lang/String;");
			global::android.test.mock.MockResources._getIntArray8065 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getIntArray", "(I)[I");
			global::android.test.mock.MockResources._obtainTypedArray8066 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "obtainTypedArray", "(I)Landroid/content/res/TypedArray;");
			global::android.test.mock.MockResources._getDimension8067 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getDimension", "(I)F");
			global::android.test.mock.MockResources._getDimensionPixelOffset8068 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getDimensionPixelOffset", "(I)I");
			global::android.test.mock.MockResources._getDimensionPixelSize8069 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getDimensionPixelSize", "(I)I");
			global::android.test.mock.MockResources._getDrawable8070 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;");
			global::android.test.mock.MockResources._getMovie8071 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getMovie", "(I)Landroid/graphics/Movie;");
			global::android.test.mock.MockResources._getColor8072 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getColor", "(I)I");
			global::android.test.mock.MockResources._getColorStateList8073 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getColorStateList", "(I)Landroid/content/res/ColorStateList;");
			global::android.test.mock.MockResources._getLayout8074 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getLayout", "(I)Landroid/content/res/XmlResourceParser;");
			global::android.test.mock.MockResources._getAnimation8075 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getAnimation", "(I)Landroid/content/res/XmlResourceParser;");
			global::android.test.mock.MockResources._getXml8076 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getXml", "(I)Landroid/content/res/XmlResourceParser;");
			global::android.test.mock.MockResources._openRawResource8077 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "openRawResource", "(I)Ljava/io/InputStream;");
			global::android.test.mock.MockResources._openRawResourceFd8078 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "openRawResourceFd", "(I)Landroid/content/res/AssetFileDescriptor;");
			global::android.test.mock.MockResources._obtainAttributes8079 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "obtainAttributes", "(Landroid/util/AttributeSet;[I)Landroid/content/res/TypedArray;");
			global::android.test.mock.MockResources._updateConfiguration8080 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "updateConfiguration", "(Landroid/content/res/Configuration;Landroid/util/DisplayMetrics;)V");
			global::android.test.mock.MockResources._getDisplayMetrics8081 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getDisplayMetrics", "()Landroid/util/DisplayMetrics;");
			global::android.test.mock.MockResources._getConfiguration8082 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getConfiguration", "()Landroid/content/res/Configuration;");
			global::android.test.mock.MockResources._getResourceName8083 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getResourceName", "(I)Ljava/lang/String;");
			global::android.test.mock.MockResources._getResourcePackageName8084 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getResourcePackageName", "(I)Ljava/lang/String;");
			global::android.test.mock.MockResources._getResourceTypeName8085 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getResourceTypeName", "(I)Ljava/lang/String;");
			global::android.test.mock.MockResources._getResourceEntryName8086 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getResourceEntryName", "(I)Ljava/lang/String;");
			global::android.test.mock.MockResources._MockResources8087 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "<init>", "()V");
		}
	}
}
