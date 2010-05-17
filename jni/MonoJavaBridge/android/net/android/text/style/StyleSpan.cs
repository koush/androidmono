namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class StyleSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{ 
		internal new static global::java.lang.Class staticClass; 
		static StyleSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.style.StyleSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.StyleSpan(@__env); 
			} 
		} 
		protected StyleSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7036; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.StyleSpan)) 
				@__env.CallVoidMethod(this, _writeToParcel7036, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.StyleSpan.staticClass, _writeToParcel7036, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7037; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.StyleSpan)) 
				return @__env.CallIntMethod(this, _describeContents7037); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.StyleSpan.staticClass, _describeContents7037); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStyle7038; 
		public virtual int getStyle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.StyleSpan)) 
				return @__env.CallIntMethod(this, _getStyle7038); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.StyleSpan.staticClass, _getStyle7038); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId7039; 
		public virtual int getSpanTypeId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.StyleSpan)) 
				return @__env.CallIntMethod(this, _getSpanTypeId7039); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.StyleSpan.staticClass, _getSpanTypeId7039); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState7040; 
		public override void updateDrawState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.StyleSpan)) 
				@__env.CallVoidMethod(this, _updateDrawState7040, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.StyleSpan.staticClass, _updateDrawState7040, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateMeasureState7041; 
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.StyleSpan)) 
				@__env.CallVoidMethod(this, _updateMeasureState7041, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.StyleSpan.staticClass, _updateMeasureState7041, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _StyleSpan7042; 
		public StyleSpan(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.StyleSpan.staticClass, _StyleSpan7042, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _StyleSpan7043; 
		public StyleSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.StyleSpan.staticClass, _StyleSpan7043, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.StyleSpan.staticClass = @__class; 
			global::android.text.style.StyleSpan._writeToParcel7036 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.text.style.StyleSpan._describeContents7037 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "describeContents", "()I"); 
			global::android.text.style.StyleSpan._getStyle7038 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "getStyle", "()I"); 
			global::android.text.style.StyleSpan._getSpanTypeId7039 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "getSpanTypeId", "()I"); 
			global::android.text.style.StyleSpan._updateDrawState7040 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.StyleSpan._updateMeasureState7041 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.StyleSpan._StyleSpan7042 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "<init>", "(I)V"); 
			global::android.text.style.StyleSpan._StyleSpan7043 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
