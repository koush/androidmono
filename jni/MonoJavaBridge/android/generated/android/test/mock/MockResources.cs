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
		internal static global::MonoJavaBridge.MethodId _getValue12530;
		public override void getValue(int arg0, android.util.TypedValue arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockResources._getValue12530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getValue12530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getValue12531;
		public override void getValue(java.lang.String arg0, android.util.TypedValue arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockResources._getValue12531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getValue12531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getInteger12532;
		public override int getInteger(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockResources._getInteger12532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getInteger12532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getString12533;
		public override global::java.lang.String getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getString12533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getString12533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getString12534;
		public override global::java.lang.String getString(int arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getString12534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getString12534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getIdentifier12535;
		public override int getIdentifier(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockResources._getIdentifier12535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getIdentifier12535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getText12536;
		public override global::java.lang.CharSequence getText(int arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getText12536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getText12536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		public java.lang.CharSequence getText(int arg0, string arg1)
		{
			return getText(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _getText12537;
		public override global::java.lang.CharSequence getText(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getText12537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getText12537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getQuantityText12538;
		public override global::java.lang.CharSequence getQuantityText(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getQuantityText12538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getQuantityText12538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getQuantityString12539;
		public override global::java.lang.String getQuantityString(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getQuantityString12539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getQuantityString12539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getQuantityString12540;
		public override global::java.lang.String getQuantityString(int arg0, int arg1, java.lang.Object[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getQuantityString12540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getQuantityString12540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTextArray12541;
		public override global::java.lang.CharSequence[] getTextArray(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getTextArray12541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getTextArray12541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence[];
		}
		internal static global::MonoJavaBridge.MethodId _getStringArray12542;
		public override global::java.lang.String[] getStringArray(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getStringArray12542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getStringArray12542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getIntArray12543;
		public override int[] getIntArray(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getIntArray12543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getIntArray12543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _obtainTypedArray12544;
		public override global::android.content.res.TypedArray obtainTypedArray(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._obtainTypedArray12544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.TypedArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._obtainTypedArray12544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.TypedArray;
		}
		internal static global::MonoJavaBridge.MethodId _getDimension12545;
		public override float getDimension(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.test.mock.MockResources._getDimension12545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getDimension12545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDimensionPixelOffset12546;
		public override int getDimensionPixelOffset(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockResources._getDimensionPixelOffset12546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getDimensionPixelOffset12546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDimensionPixelSize12547;
		public override int getDimensionPixelSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockResources._getDimensionPixelSize12547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getDimensionPixelSize12547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable12548;
		public override global::android.graphics.drawable.Drawable getDrawable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getDrawable12548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getDrawable12548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getMovie12549;
		public override global::android.graphics.Movie getMovie(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getMovie12549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Movie;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getMovie12549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Movie;
		}
		internal static global::MonoJavaBridge.MethodId _getColor12550;
		public override int getColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockResources._getColor12550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getColor12550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColorStateList12551;
		public override global::android.content.res.ColorStateList getColorStateList(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getColorStateList12551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getColorStateList12551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _getLayout12552;
		public override global::android.content.res.XmlResourceParser getLayout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getLayout12552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.XmlResourceParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getLayout12552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.XmlResourceParser;
		}
		internal static global::MonoJavaBridge.MethodId _getAnimation12553;
		public override global::android.content.res.XmlResourceParser getAnimation(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getAnimation12553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.XmlResourceParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getAnimation12553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.XmlResourceParser;
		}
		internal static global::MonoJavaBridge.MethodId _getXml12554;
		public override global::android.content.res.XmlResourceParser getXml(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getXml12554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.XmlResourceParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getXml12554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.XmlResourceParser;
		}
		internal static global::MonoJavaBridge.MethodId _openRawResource12555;
		public override global::java.io.InputStream openRawResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._openRawResource12555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._openRawResource12555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _openRawResourceFd12556;
		public override global::android.content.res.AssetFileDescriptor openRawResourceFd(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._openRawResourceFd12556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.AssetFileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._openRawResourceFd12556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.AssetFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _obtainAttributes12557;
		public override global::android.content.res.TypedArray obtainAttributes(android.util.AttributeSet arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._obtainAttributes12557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.TypedArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._obtainAttributes12557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.TypedArray;
		}
		internal static global::MonoJavaBridge.MethodId _updateConfiguration12558;
		public override void updateConfiguration(android.content.res.Configuration arg0, android.util.DisplayMetrics arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockResources._updateConfiguration12558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._updateConfiguration12558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.util.DisplayMetrics DisplayMetrics
		{
			get
			{
				return getDisplayMetrics();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayMetrics12559;
		public override global::android.util.DisplayMetrics getDisplayMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getDisplayMetrics12559)) as android.util.DisplayMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getDisplayMetrics12559)) as android.util.DisplayMetrics;
		}
		public new global::android.content.res.Configuration Configuration
		{
			get
			{
				return getConfiguration();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConfiguration12560;
		public override global::android.content.res.Configuration getConfiguration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getConfiguration12560)) as android.content.res.Configuration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getConfiguration12560)) as android.content.res.Configuration;
		}
		internal static global::MonoJavaBridge.MethodId _getResourceName12561;
		public override global::java.lang.String getResourceName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getResourceName12561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getResourceName12561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getResourcePackageName12562;
		public override global::java.lang.String getResourcePackageName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getResourcePackageName12562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getResourcePackageName12562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getResourceTypeName12563;
		public override global::java.lang.String getResourceTypeName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getResourceTypeName12563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getResourceTypeName12563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getResourceEntryName12564;
		public override global::java.lang.String getResourceEntryName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockResources._getResourceEntryName12564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getResourceEntryName12564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _MockResources12565;
		public MockResources()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._MockResources12565);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.mock.MockResources.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/mock/MockResources"));
			global::android.test.mock.MockResources._getValue12530 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getValue", "(ILandroid/util/TypedValue;Z)V");
			global::android.test.mock.MockResources._getValue12531 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getValue", "(Ljava/lang/String;Landroid/util/TypedValue;Z)V");
			global::android.test.mock.MockResources._getInteger12532 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getInteger", "(I)I");
			global::android.test.mock.MockResources._getString12533 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.test.mock.MockResources._getString12534 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getString", "(I[Ljava/lang/Object;)Ljava/lang/String;");
			global::android.test.mock.MockResources._getIdentifier12535 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getIdentifier", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I");
			global::android.test.mock.MockResources._getText12536 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getText", "(ILjava/lang/CharSequence;)Ljava/lang/CharSequence;");
			global::android.test.mock.MockResources._getText12537 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getText", "(I)Ljava/lang/CharSequence;");
			global::android.test.mock.MockResources._getQuantityText12538 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getQuantityText", "(II)Ljava/lang/CharSequence;");
			global::android.test.mock.MockResources._getQuantityString12539 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getQuantityString", "(II)Ljava/lang/String;");
			global::android.test.mock.MockResources._getQuantityString12540 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getQuantityString", "(II[Ljava/lang/Object;)Ljava/lang/String;");
			global::android.test.mock.MockResources._getTextArray12541 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getTextArray", "(I)[Ljava/lang/CharSequence;");
			global::android.test.mock.MockResources._getStringArray12542 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getStringArray", "(I)[Ljava/lang/String;");
			global::android.test.mock.MockResources._getIntArray12543 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getIntArray", "(I)[I");
			global::android.test.mock.MockResources._obtainTypedArray12544 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "obtainTypedArray", "(I)Landroid/content/res/TypedArray;");
			global::android.test.mock.MockResources._getDimension12545 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getDimension", "(I)F");
			global::android.test.mock.MockResources._getDimensionPixelOffset12546 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getDimensionPixelOffset", "(I)I");
			global::android.test.mock.MockResources._getDimensionPixelSize12547 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getDimensionPixelSize", "(I)I");
			global::android.test.mock.MockResources._getDrawable12548 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;");
			global::android.test.mock.MockResources._getMovie12549 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getMovie", "(I)Landroid/graphics/Movie;");
			global::android.test.mock.MockResources._getColor12550 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getColor", "(I)I");
			global::android.test.mock.MockResources._getColorStateList12551 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getColorStateList", "(I)Landroid/content/res/ColorStateList;");
			global::android.test.mock.MockResources._getLayout12552 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getLayout", "(I)Landroid/content/res/XmlResourceParser;");
			global::android.test.mock.MockResources._getAnimation12553 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getAnimation", "(I)Landroid/content/res/XmlResourceParser;");
			global::android.test.mock.MockResources._getXml12554 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getXml", "(I)Landroid/content/res/XmlResourceParser;");
			global::android.test.mock.MockResources._openRawResource12555 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "openRawResource", "(I)Ljava/io/InputStream;");
			global::android.test.mock.MockResources._openRawResourceFd12556 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "openRawResourceFd", "(I)Landroid/content/res/AssetFileDescriptor;");
			global::android.test.mock.MockResources._obtainAttributes12557 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "obtainAttributes", "(Landroid/util/AttributeSet;[I)Landroid/content/res/TypedArray;");
			global::android.test.mock.MockResources._updateConfiguration12558 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "updateConfiguration", "(Landroid/content/res/Configuration;Landroid/util/DisplayMetrics;)V");
			global::android.test.mock.MockResources._getDisplayMetrics12559 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getDisplayMetrics", "()Landroid/util/DisplayMetrics;");
			global::android.test.mock.MockResources._getConfiguration12560 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getConfiguration", "()Landroid/content/res/Configuration;");
			global::android.test.mock.MockResources._getResourceName12561 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getResourceName", "(I)Ljava/lang/String;");
			global::android.test.mock.MockResources._getResourcePackageName12562 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getResourcePackageName", "(I)Ljava/lang/String;");
			global::android.test.mock.MockResources._getResourceTypeName12563 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getResourceTypeName", "(I)Ljava/lang/String;");
			global::android.test.mock.MockResources._getResourceEntryName12564 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getResourceEntryName", "(I)Ljava/lang/String;");
			global::android.test.mock.MockResources._MockResources12565 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "<init>", "()V");
		}
	}
}
