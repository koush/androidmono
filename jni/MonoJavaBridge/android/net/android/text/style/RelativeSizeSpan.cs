namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class RelativeSizeSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{ 
		internal new static global::java.lang.Class staticClass; 
		static RelativeSizeSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.style.RelativeSizeSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.RelativeSizeSpan(@__env); 
			} 
		} 
		protected RelativeSizeSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7386; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.RelativeSizeSpan)) 
				@__env.CallVoidMethod(this, _writeToParcel7386, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.RelativeSizeSpan.staticClass, _writeToParcel7386, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7387; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.RelativeSizeSpan)) 
				return @__env.CallIntMethod(this, _describeContents7387); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.RelativeSizeSpan.staticClass, _describeContents7387); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId7388; 
		public virtual int getSpanTypeId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.RelativeSizeSpan)) 
				return @__env.CallIntMethod(this, _getSpanTypeId7388); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.RelativeSizeSpan.staticClass, _getSpanTypeId7388); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState7389; 
		public override void updateDrawState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.RelativeSizeSpan)) 
				@__env.CallVoidMethod(this, _updateDrawState7389, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.RelativeSizeSpan.staticClass, _updateDrawState7389, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateMeasureState7390; 
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.RelativeSizeSpan)) 
				@__env.CallVoidMethod(this, _updateMeasureState7390, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.RelativeSizeSpan.staticClass, _updateMeasureState7390, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSizeChange7391; 
		public virtual float getSizeChange() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.RelativeSizeSpan)) 
				return @__env.CallFloatMethod(this, _getSizeChange7391); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.text.style.RelativeSizeSpan.staticClass, _getSizeChange7391); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RelativeSizeSpan7392; 
		public RelativeSizeSpan(float arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.RelativeSizeSpan.staticClass, _RelativeSizeSpan7392, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RelativeSizeSpan7393; 
		public RelativeSizeSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.RelativeSizeSpan.staticClass, _RelativeSizeSpan7393, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.RelativeSizeSpan.staticClass = @__class; 
			global::android.text.style.RelativeSizeSpan._writeToParcel7386 = @__env.GetMethodID(global::android.text.style.RelativeSizeSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.text.style.RelativeSizeSpan._describeContents7387 = @__env.GetMethodID(global::android.text.style.RelativeSizeSpan.staticClass, "describeContents", "()I"); 
			global::android.text.style.RelativeSizeSpan._getSpanTypeId7388 = @__env.GetMethodID(global::android.text.style.RelativeSizeSpan.staticClass, "getSpanTypeId", "()I"); 
			global::android.text.style.RelativeSizeSpan._updateDrawState7389 = @__env.GetMethodID(global::android.text.style.RelativeSizeSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.RelativeSizeSpan._updateMeasureState7390 = @__env.GetMethodID(global::android.text.style.RelativeSizeSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.RelativeSizeSpan._getSizeChange7391 = @__env.GetMethodID(global::android.text.style.RelativeSizeSpan.staticClass, "getSizeChange", "()F"); 
			global::android.text.style.RelativeSizeSpan._RelativeSizeSpan7392 = @__env.GetMethodID(global::android.text.style.RelativeSizeSpan.staticClass, "<init>", "(F)V"); 
			global::android.text.style.RelativeSizeSpan._RelativeSizeSpan7393 = @__env.GetMethodID(global::android.text.style.RelativeSizeSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
