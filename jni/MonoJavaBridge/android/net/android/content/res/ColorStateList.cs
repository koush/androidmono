namespace android.content.res 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ColorStateList : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static ColorStateList() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.res.ColorStateList), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _toString1868; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.ColorStateList)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString1868)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.ColorStateList.staticClass, _toString1868)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _valueOf1869; 
		public static android.content.res.ColorStateList valueOf(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallStaticObjectMethodPtr(android.content.res.ColorStateList.staticClass, _valueOf1869, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1870; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.ColorStateList)) 
				@__env.CallVoidMethod(this, _writeToParcel1870, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.res.ColorStateList.staticClass, _writeToParcel1870, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1871; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.ColorStateList)) 
				return @__env.CallIntMethod(this, _describeContents1871); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.ColorStateList.staticClass, _describeContents1871); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isStateful1872; 
		public virtual bool isStateful() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.ColorStateList)) 
				return @__env.CallBooleanMethod(this, _isStateful1872); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.res.ColorStateList.staticClass, _isStateful1872); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromXml1873; 
		public static android.content.res.ColorStateList createFromXml(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallStaticObjectMethodPtr(android.content.res.ColorStateList.staticClass, _createFromXml1873, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _withAlpha1874; 
		public virtual android.content.res.ColorStateList withAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.ColorStateList)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallObjectMethodPtr(this, _withAlpha1874, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.ColorStateList.staticClass, _withAlpha1874, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColorForState1875; 
		public virtual int getColorForState(int[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.ColorStateList)) 
				return @__env.CallIntMethod(this, _getColorForState1875, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.ColorStateList.staticClass, _getColorForState1875, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultColor1876; 
		public virtual int getDefaultColor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.ColorStateList)) 
				return @__env.CallIntMethod(this, _getDefaultColor1876); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.ColorStateList.staticClass, _getDefaultColor1876); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ColorStateList1877; 
		public ColorStateList(int[][] arg0, int[] arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.res.ColorStateList.staticClass, _ColorStateList1877, this, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1878; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.res.ColorStateList.staticClass = @__class; 
			global::android.content.res.ColorStateList._toString1868 = @__env.GetMethodID(global::android.content.res.ColorStateList.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.res.ColorStateList._valueOf1869 = @__env.GetStaticMethodID(global::android.content.res.ColorStateList.staticClass, "valueOf", "(I)Landroid/content/res/ColorStateList;"); 
			global::android.content.res.ColorStateList._writeToParcel1870 = @__env.GetMethodID(global::android.content.res.ColorStateList.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.res.ColorStateList._describeContents1871 = @__env.GetMethodID(global::android.content.res.ColorStateList.staticClass, "describeContents", "()I"); 
			global::android.content.res.ColorStateList._isStateful1872 = @__env.GetMethodID(global::android.content.res.ColorStateList.staticClass, "isStateful", "()Z"); 
			global::android.content.res.ColorStateList._createFromXml1873 = @__env.GetStaticMethodID(global::android.content.res.ColorStateList.staticClass, "createFromXml", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;)Landroid/content/res/ColorStateList;"); 
			global::android.content.res.ColorStateList._withAlpha1874 = @__env.GetMethodID(global::android.content.res.ColorStateList.staticClass, "withAlpha", "(I)Landroid/content/res/ColorStateList;"); 
			global::android.content.res.ColorStateList._getColorForState1875 = @__env.GetMethodID(global::android.content.res.ColorStateList.staticClass, "getColorForState", "([II)I"); 
			global::android.content.res.ColorStateList._getDefaultColor1876 = @__env.GetMethodID(global::android.content.res.ColorStateList.staticClass, "getDefaultColor", "()I"); 
			global::android.content.res.ColorStateList._ColorStateList1877 = @__env.GetMethodID(global::android.content.res.ColorStateList.staticClass, "<init>", "([[I[I)V"); 
		} 
	} 
} 
