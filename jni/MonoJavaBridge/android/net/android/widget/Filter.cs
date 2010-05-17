namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class Filter : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Filter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.Filter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected Filter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface FilterListener 
		{ 
			void onFilterComplete(int arg0); 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		protected class FilterResults : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static FilterResults() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.Filter.FilterResults), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.Filter.FilterResults(@__env); 
				} 
			} 
			protected FilterResults(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _FilterResults9452; 
			public FilterResults()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.Filter.FilterResults.staticClass, _FilterResults9452, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _values9453; 
			public java.lang.Object values
			{ 
				get 
				{ 
					return default(java.lang.Object); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _count9454; 
			public int count
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.Filter.FilterResults.staticClass = @__class; 
				global::android.widget.Filter.FilterResults._FilterResults9452 = @__env.GetMethodID(global::android.widget.Filter.FilterResults.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _filter9455; 
		public virtual void filter(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Filter)) 
				@__env.CallVoidMethod(this, _filter9455, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Filter.staticClass, _filter9455, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _filter9456; 
		public virtual void filter(java.lang.CharSequence arg0, android.widget.Filter.FilterListener arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Filter)) 
				@__env.CallVoidMethod(this, _filter9456, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Filter.staticClass, _filter9456, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performFiltering9457; 
		protected abstract android.widget.Filter.FilterResults performFiltering(java.lang.CharSequence arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _publishResults9458; 
		protected abstract void publishResults(java.lang.CharSequence arg0, android.widget.Filter.FilterResults arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _convertResultToString9459; 
		public virtual java.lang.CharSequence convertResultToString(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Filter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _convertResultToString9459, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.Filter.staticClass, _convertResultToString9459, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Filter9460; 
		public Filter()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.Filter.staticClass, _Filter9460, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.Filter.staticClass = @__class; 
			global::android.widget.Filter._filter9455 = @__env.GetMethodID(global::android.widget.Filter.staticClass, "filter", "(Ljava/lang/CharSequence;)V"); 
			global::android.widget.Filter._filter9456 = @__env.GetMethodID(global::android.widget.Filter.staticClass, "filter", "(Ljava/lang/CharSequence;Landroid/widget/Filter$FilterListener;)V"); 
			global::android.widget.Filter._performFiltering9457 = @__env.GetMethodID(global::android.widget.Filter.staticClass, "performFiltering", "(Ljava/lang/CharSequence;)Landroid/widget/Filter$FilterResults;"); 
			global::android.widget.Filter._publishResults9458 = @__env.GetMethodID(global::android.widget.Filter.staticClass, "publishResults", "(Ljava/lang/CharSequence;Landroid/widget/Filter$FilterResults;)V"); 
			global::android.widget.Filter._convertResultToString9459 = @__env.GetMethodID(global::android.widget.Filter.staticClass, "convertResultToString", "(Ljava/lang/Object;)Ljava/lang/CharSequence;"); 
			global::android.widget.Filter._Filter9460 = @__env.GetMethodID(global::android.widget.Filter.staticClass, "<init>", "()V"); 
		} 
	} 
} 
