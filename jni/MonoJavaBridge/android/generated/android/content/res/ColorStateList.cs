namespace android.content.res
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ColorStateList : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static ColorStateList()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.res.ColorStateList), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.res.ColorStateList(@__env);
			}
		}
		protected ColorStateList(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString1913;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.ColorStateList._toString1913));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._toString1913));
		}
		internal static global::net.sf.jni4net.jni.MethodId _valueOf1914;
		public static global::android.content.res.ColorStateList valueOf(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallStaticObjectMethodPtr(android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._valueOf1914, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1915;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.ColorStateList._writeToParcel1915, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._writeToParcel1915, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1916;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.ColorStateList._describeContents1916);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._describeContents1916);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isStateful1917;
		public virtual bool isStateful() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.res.ColorStateList._isStateful1917);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._isStateful1917);
		}
		internal static global::net.sf.jni4net.jni.MethodId _createFromXml1918;
		public static global::android.content.res.ColorStateList createFromXml(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallStaticObjectMethodPtr(android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._createFromXml1918, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _withAlpha1919;
		public virtual global::android.content.res.ColorStateList withAlpha(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.ColorStateList._withAlpha1919, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._withAlpha1919, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColorForState1920;
		public virtual int getColorForState(int[] arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.ColorStateList._getColorForState1920, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._getColorForState1920, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultColor1921;
		public virtual int getDefaultColor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.ColorStateList._getDefaultColor1921);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._getDefaultColor1921);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ColorStateList1922;
		public ColorStateList(int[][] arg0, int[] arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.res.ColorStateList.staticClass, global::android.content.res.ColorStateList._ColorStateList1922, this, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1923;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.res.ColorStateList.staticClass = @__class;
			global::android.content.res.ColorStateList._toString1913 = @__env.GetMethodID(global::android.content.res.ColorStateList.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.res.ColorStateList._valueOf1914 = @__env.GetStaticMethodID(global::android.content.res.ColorStateList.staticClass, "valueOf", "(I)Landroid/content/res/ColorStateList;");
			global::android.content.res.ColorStateList._writeToParcel1915 = @__env.GetMethodID(global::android.content.res.ColorStateList.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.res.ColorStateList._describeContents1916 = @__env.GetMethodID(global::android.content.res.ColorStateList.staticClass, "describeContents", "()I");
			global::android.content.res.ColorStateList._isStateful1917 = @__env.GetMethodID(global::android.content.res.ColorStateList.staticClass, "isStateful", "()Z");
			global::android.content.res.ColorStateList._createFromXml1918 = @__env.GetStaticMethodID(global::android.content.res.ColorStateList.staticClass, "createFromXml", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;)Landroid/content/res/ColorStateList;");
			global::android.content.res.ColorStateList._withAlpha1919 = @__env.GetMethodID(global::android.content.res.ColorStateList.staticClass, "withAlpha", "(I)Landroid/content/res/ColorStateList;");
			global::android.content.res.ColorStateList._getColorForState1920 = @__env.GetMethodID(global::android.content.res.ColorStateList.staticClass, "getColorForState", "([II)I");
			global::android.content.res.ColorStateList._getDefaultColor1921 = @__env.GetMethodID(global::android.content.res.ColorStateList.staticClass, "getDefaultColor", "()I");
			global::android.content.res.ColorStateList._ColorStateList1922 = @__env.GetMethodID(global::android.content.res.ColorStateList.staticClass, "<init>", "([[I[I)V");
		}
	}
}
