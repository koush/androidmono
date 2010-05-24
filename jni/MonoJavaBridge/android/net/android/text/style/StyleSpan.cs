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
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7413; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.StyleSpan)) 
				@__env.CallVoidMethod(this, _writeToParcel7413, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.StyleSpan.staticClass, _writeToParcel7413, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7414; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.StyleSpan)) 
				return @__env.CallIntMethod(this, _describeContents7414); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.StyleSpan.staticClass, _describeContents7414); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStyle7415; 
		public virtual int getStyle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.StyleSpan)) 
				return @__env.CallIntMethod(this, _getStyle7415); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.StyleSpan.staticClass, _getStyle7415); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId7416; 
		public virtual int getSpanTypeId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.StyleSpan)) 
				return @__env.CallIntMethod(this, _getSpanTypeId7416); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.StyleSpan.staticClass, _getSpanTypeId7416); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState7417; 
		public override void updateDrawState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.StyleSpan)) 
				@__env.CallVoidMethod(this, _updateDrawState7417, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.StyleSpan.staticClass, _updateDrawState7417, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateMeasureState7418; 
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.StyleSpan)) 
				@__env.CallVoidMethod(this, _updateMeasureState7418, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.StyleSpan.staticClass, _updateMeasureState7418, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _StyleSpan7419; 
		public StyleSpan(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.StyleSpan.staticClass, _StyleSpan7419, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _StyleSpan7420; 
		public StyleSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.StyleSpan.staticClass, _StyleSpan7420, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.StyleSpan.staticClass = @__class; 
			global::android.text.style.StyleSpan._writeToParcel7413 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.text.style.StyleSpan._describeContents7414 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "describeContents", "()I"); 
			global::android.text.style.StyleSpan._getStyle7415 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "getStyle", "()I"); 
			global::android.text.style.StyleSpan._getSpanTypeId7416 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "getSpanTypeId", "()I"); 
			global::android.text.style.StyleSpan._updateDrawState7417 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.StyleSpan._updateMeasureState7418 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.StyleSpan._StyleSpan7419 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "<init>", "(I)V"); 
			global::android.text.style.StyleSpan._StyleSpan7420 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
