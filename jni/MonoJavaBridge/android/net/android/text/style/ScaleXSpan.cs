namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ScaleXSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ScaleXSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.ScaleXSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.ScaleXSpan(@__env); 
			} 
		} 
		protected ScaleXSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7399; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.ScaleXSpan)) 
				@__env.CallVoidMethod(this, global::android.text.style.ScaleXSpan._writeToParcel7399, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._writeToParcel7399, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7400; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.ScaleXSpan)) 
				return @__env.CallIntMethod(this, global::android.text.style.ScaleXSpan._describeContents7400); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._describeContents7400); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId7401; 
		public virtual int getSpanTypeId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.ScaleXSpan)) 
				return @__env.CallIntMethod(this, global::android.text.style.ScaleXSpan._getSpanTypeId7401); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._getSpanTypeId7401); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState7402; 
		public override void updateDrawState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.ScaleXSpan)) 
				@__env.CallVoidMethod(this, global::android.text.style.ScaleXSpan._updateDrawState7402, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._updateDrawState7402, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateMeasureState7403; 
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.ScaleXSpan)) 
				@__env.CallVoidMethod(this, global::android.text.style.ScaleXSpan._updateMeasureState7403, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._updateMeasureState7403, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaleX7404; 
		public virtual float getScaleX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.ScaleXSpan)) 
				return @__env.CallFloatMethod(this, global::android.text.style.ScaleXSpan._getScaleX7404); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._getScaleX7404); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ScaleXSpan7405; 
		public ScaleXSpan(float arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._ScaleXSpan7405, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ScaleXSpan7406; 
		public ScaleXSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._ScaleXSpan7406, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.ScaleXSpan.staticClass = @__class; 
			global::android.text.style.ScaleXSpan._writeToParcel7399 = @__env.GetMethodID(global::android.text.style.ScaleXSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.text.style.ScaleXSpan._describeContents7400 = @__env.GetMethodID(global::android.text.style.ScaleXSpan.staticClass, "describeContents", "()I"); 
			global::android.text.style.ScaleXSpan._getSpanTypeId7401 = @__env.GetMethodID(global::android.text.style.ScaleXSpan.staticClass, "getSpanTypeId", "()I"); 
			global::android.text.style.ScaleXSpan._updateDrawState7402 = @__env.GetMethodID(global::android.text.style.ScaleXSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.ScaleXSpan._updateMeasureState7403 = @__env.GetMethodID(global::android.text.style.ScaleXSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.ScaleXSpan._getScaleX7404 = @__env.GetMethodID(global::android.text.style.ScaleXSpan.staticClass, "getScaleX", "()F"); 
			global::android.text.style.ScaleXSpan._ScaleXSpan7405 = @__env.GetMethodID(global::android.text.style.ScaleXSpan.staticClass, "<init>", "(F)V"); 
			global::android.text.style.ScaleXSpan._ScaleXSpan7406 = @__env.GetMethodID(global::android.text.style.ScaleXSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
