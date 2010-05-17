namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TypefaceSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{ 
		internal new static global::java.lang.Class staticClass; 
		static TypefaceSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.style.TypefaceSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.TypefaceSpan(@__env); 
			} 
		} 
		protected TypefaceSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7074; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.TypefaceSpan)) 
				@__env.CallVoidMethod(this, _writeToParcel7074, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.TypefaceSpan.staticClass, _writeToParcel7074, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7075; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.TypefaceSpan)) 
				return @__env.CallIntMethod(this, _describeContents7075); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.TypefaceSpan.staticClass, _describeContents7075); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId7076; 
		public virtual int getSpanTypeId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.TypefaceSpan)) 
				return @__env.CallIntMethod(this, _getSpanTypeId7076); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.TypefaceSpan.staticClass, _getSpanTypeId7076); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState7077; 
		public override void updateDrawState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.TypefaceSpan)) 
				@__env.CallVoidMethod(this, _updateDrawState7077, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.TypefaceSpan.staticClass, _updateDrawState7077, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateMeasureState7078; 
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.TypefaceSpan)) 
				@__env.CallVoidMethod(this, _updateMeasureState7078, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.TypefaceSpan.staticClass, _updateMeasureState7078, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFamily7079; 
		public virtual java.lang.String getFamily() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.TypefaceSpan)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getFamily7079)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.style.TypefaceSpan.staticClass, _getFamily7079)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TypefaceSpan7080; 
		public TypefaceSpan(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.TypefaceSpan.staticClass, _TypefaceSpan7080, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TypefaceSpan7081; 
		public TypefaceSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.TypefaceSpan.staticClass, _TypefaceSpan7081, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.TypefaceSpan.staticClass = @__class; 
			global::android.text.style.TypefaceSpan._writeToParcel7074 = @__env.GetMethodID(global::android.text.style.TypefaceSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.text.style.TypefaceSpan._describeContents7075 = @__env.GetMethodID(global::android.text.style.TypefaceSpan.staticClass, "describeContents", "()I"); 
			global::android.text.style.TypefaceSpan._getSpanTypeId7076 = @__env.GetMethodID(global::android.text.style.TypefaceSpan.staticClass, "getSpanTypeId", "()I"); 
			global::android.text.style.TypefaceSpan._updateDrawState7077 = @__env.GetMethodID(global::android.text.style.TypefaceSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.TypefaceSpan._updateMeasureState7078 = @__env.GetMethodID(global::android.text.style.TypefaceSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.TypefaceSpan._getFamily7079 = @__env.GetMethodID(global::android.text.style.TypefaceSpan.staticClass, "getFamily", "()Ljava/lang/String;"); 
			global::android.text.style.TypefaceSpan._TypefaceSpan7080 = @__env.GetMethodID(global::android.text.style.TypefaceSpan.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::android.text.style.TypefaceSpan._TypefaceSpan7081 = @__env.GetMethodID(global::android.text.style.TypefaceSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
