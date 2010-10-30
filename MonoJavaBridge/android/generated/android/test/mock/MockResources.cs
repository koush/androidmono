namespace android.test.mock
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MockResources : android.content.res.Resources
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MockResources(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getValue12588;
		public override void getValue(int arg0, android.util.TypedValue arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getValue12588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getValue12589;
		public override void getValue(java.lang.String arg0, android.util.TypedValue arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getValue12589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getInteger12590;
		public override int getInteger(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getInteger12590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getString12591;
		public override global::java.lang.String getString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getString12591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getString12592;
		public override global::java.lang.String getString(int arg0, java.lang.Object[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getString12592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getIdentifier12593;
		public override int getIdentifier(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getIdentifier12593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getText12594;
		public override global::java.lang.CharSequence getText(int arg0, java.lang.CharSequence arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getText12594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		public java.lang.CharSequence getText(int arg0, string arg1)
		{
			return getText(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _getText12595;
		public override global::java.lang.CharSequence getText(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getText12595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getQuantityText12596;
		public override global::java.lang.CharSequence getQuantityText(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getQuantityText12596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getQuantityString12597;
		public override global::java.lang.String getQuantityString(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getQuantityString12597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getQuantityString12598;
		public override global::java.lang.String getQuantityString(int arg0, int arg1, java.lang.Object[] arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getQuantityString12598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTextArray12599;
		public override global::java.lang.CharSequence[] getTextArray(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getTextArray12599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence[];
		}
		internal static global::MonoJavaBridge.MethodId _getStringArray12600;
		public override global::java.lang.String[] getStringArray(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getStringArray12600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getIntArray12601;
		public override int[] getIntArray(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getIntArray12601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _obtainTypedArray12602;
		public override global::android.content.res.TypedArray obtainTypedArray(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._obtainTypedArray12602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.TypedArray;
		}
		internal static global::MonoJavaBridge.MethodId _getDimension12603;
		public override float getDimension(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getDimension12603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDimensionPixelOffset12604;
		public override int getDimensionPixelOffset(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getDimensionPixelOffset12604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDimensionPixelSize12605;
		public override int getDimensionPixelSize(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getDimensionPixelSize12605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable12606;
		public override global::android.graphics.drawable.Drawable getDrawable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getDrawable12606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getMovie12607;
		public override global::android.graphics.Movie getMovie(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getMovie12607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Movie;
		}
		internal static global::MonoJavaBridge.MethodId _getColor12608;
		public override int getColor(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getColor12608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColorStateList12609;
		public override global::android.content.res.ColorStateList getColorStateList(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getColorStateList12609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _getLayout12610;
		public override global::android.content.res.XmlResourceParser getLayout(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getLayout12610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.XmlResourceParser;
		}
		internal static global::MonoJavaBridge.MethodId _getAnimation12611;
		public override global::android.content.res.XmlResourceParser getAnimation(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getAnimation12611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.XmlResourceParser;
		}
		internal static global::MonoJavaBridge.MethodId _getXml12612;
		public override global::android.content.res.XmlResourceParser getXml(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getXml12612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.XmlResourceParser;
		}
		internal static global::MonoJavaBridge.MethodId _openRawResource12613;
		public override global::java.io.InputStream openRawResource(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._openRawResource12613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _openRawResourceFd12614;
		public override global::android.content.res.AssetFileDescriptor openRawResourceFd(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._openRawResourceFd12614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.AssetFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _obtainAttributes12615;
		public override global::android.content.res.TypedArray obtainAttributes(android.util.AttributeSet arg0, int[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._obtainAttributes12615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.TypedArray;
		}
		internal static global::MonoJavaBridge.MethodId _updateConfiguration12616;
		public override void updateConfiguration(android.content.res.Configuration arg0, android.util.DisplayMetrics arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._updateConfiguration12616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.util.DisplayMetrics DisplayMetrics
		{
			get
			{
				return getDisplayMetrics();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayMetrics12617;
		public override global::android.util.DisplayMetrics getDisplayMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getDisplayMetrics12617)) as android.util.DisplayMetrics;
		}
		public new global::android.content.res.Configuration Configuration
		{
			get
			{
				return getConfiguration();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConfiguration12618;
		public override global::android.content.res.Configuration getConfiguration()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.res.Configuration>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getConfiguration12618)) as android.content.res.Configuration;
		}
		internal static global::MonoJavaBridge.MethodId _getResourceName12619;
		public override global::java.lang.String getResourceName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getResourceName12619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getResourcePackageName12620;
		public override global::java.lang.String getResourcePackageName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getResourcePackageName12620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getResourceTypeName12621;
		public override global::java.lang.String getResourceTypeName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getResourceTypeName12621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getResourceEntryName12622;
		public override global::java.lang.String getResourceEntryName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._getResourceEntryName12622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _MockResources12623;
		public MockResources() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.mock.MockResources.staticClass, global::android.test.mock.MockResources._MockResources12623);
			Init(@__env, handle);
		}
		static MockResources()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.mock.MockResources.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/mock/MockResources"));
			global::android.test.mock.MockResources._getValue12588 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getValue", "(ILandroid/util/TypedValue;Z)V");
			global::android.test.mock.MockResources._getValue12589 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getValue", "(Ljava/lang/String;Landroid/util/TypedValue;Z)V");
			global::android.test.mock.MockResources._getInteger12590 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getInteger", "(I)I");
			global::android.test.mock.MockResources._getString12591 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.test.mock.MockResources._getString12592 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getString", "(I[Ljava/lang/Object;)Ljava/lang/String;");
			global::android.test.mock.MockResources._getIdentifier12593 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getIdentifier", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I");
			global::android.test.mock.MockResources._getText12594 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getText", "(ILjava/lang/CharSequence;)Ljava/lang/CharSequence;");
			global::android.test.mock.MockResources._getText12595 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getText", "(I)Ljava/lang/CharSequence;");
			global::android.test.mock.MockResources._getQuantityText12596 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getQuantityText", "(II)Ljava/lang/CharSequence;");
			global::android.test.mock.MockResources._getQuantityString12597 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getQuantityString", "(II)Ljava/lang/String;");
			global::android.test.mock.MockResources._getQuantityString12598 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getQuantityString", "(II[Ljava/lang/Object;)Ljava/lang/String;");
			global::android.test.mock.MockResources._getTextArray12599 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getTextArray", "(I)[Ljava/lang/CharSequence;");
			global::android.test.mock.MockResources._getStringArray12600 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getStringArray", "(I)[Ljava/lang/String;");
			global::android.test.mock.MockResources._getIntArray12601 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getIntArray", "(I)[I");
			global::android.test.mock.MockResources._obtainTypedArray12602 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "obtainTypedArray", "(I)Landroid/content/res/TypedArray;");
			global::android.test.mock.MockResources._getDimension12603 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getDimension", "(I)F");
			global::android.test.mock.MockResources._getDimensionPixelOffset12604 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getDimensionPixelOffset", "(I)I");
			global::android.test.mock.MockResources._getDimensionPixelSize12605 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getDimensionPixelSize", "(I)I");
			global::android.test.mock.MockResources._getDrawable12606 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;");
			global::android.test.mock.MockResources._getMovie12607 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getMovie", "(I)Landroid/graphics/Movie;");
			global::android.test.mock.MockResources._getColor12608 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getColor", "(I)I");
			global::android.test.mock.MockResources._getColorStateList12609 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getColorStateList", "(I)Landroid/content/res/ColorStateList;");
			global::android.test.mock.MockResources._getLayout12610 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getLayout", "(I)Landroid/content/res/XmlResourceParser;");
			global::android.test.mock.MockResources._getAnimation12611 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getAnimation", "(I)Landroid/content/res/XmlResourceParser;");
			global::android.test.mock.MockResources._getXml12612 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getXml", "(I)Landroid/content/res/XmlResourceParser;");
			global::android.test.mock.MockResources._openRawResource12613 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "openRawResource", "(I)Ljava/io/InputStream;");
			global::android.test.mock.MockResources._openRawResourceFd12614 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "openRawResourceFd", "(I)Landroid/content/res/AssetFileDescriptor;");
			global::android.test.mock.MockResources._obtainAttributes12615 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "obtainAttributes", "(Landroid/util/AttributeSet;[I)Landroid/content/res/TypedArray;");
			global::android.test.mock.MockResources._updateConfiguration12616 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "updateConfiguration", "(Landroid/content/res/Configuration;Landroid/util/DisplayMetrics;)V");
			global::android.test.mock.MockResources._getDisplayMetrics12617 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getDisplayMetrics", "()Landroid/util/DisplayMetrics;");
			global::android.test.mock.MockResources._getConfiguration12618 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getConfiguration", "()Landroid/content/res/Configuration;");
			global::android.test.mock.MockResources._getResourceName12619 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getResourceName", "(I)Ljava/lang/String;");
			global::android.test.mock.MockResources._getResourcePackageName12620 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getResourcePackageName", "(I)Ljava/lang/String;");
			global::android.test.mock.MockResources._getResourceTypeName12621 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getResourceTypeName", "(I)Ljava/lang/String;");
			global::android.test.mock.MockResources._getResourceEntryName12622 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "getResourceEntryName", "(I)Ljava/lang/String;");
			global::android.test.mock.MockResources._MockResources12623 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockResources.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
