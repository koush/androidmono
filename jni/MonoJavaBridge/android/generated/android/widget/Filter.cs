namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.Filter_))]
	public abstract partial class Filter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Filter()
		{
			InitJNI();
		}
		protected Filter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.Filter.FilterListener_))]
		public interface FilterListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onFilterComplete(int arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.Filter.FilterListener))]
		public sealed partial class FilterListener_ : java.lang.Object, FilterListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static FilterListener_()
			{
				InitJNI();
			}
			internal FilterListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onFilterComplete11818;
			 void android.widget.Filter.FilterListener.onFilterComplete(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Filter.FilterListener_._onFilterComplete11818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Filter.FilterListener_.staticClass, global::android.widget.Filter.FilterListener_._onFilterComplete11818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.Filter.FilterListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Filter$FilterListener"));
				global::android.widget.Filter.FilterListener_._onFilterComplete11818 = @__env.GetMethodIDNoThrow(global::android.widget.Filter.FilterListener_.staticClass, "onFilterComplete", "(I)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		protected partial class FilterResults : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static FilterResults()
			{
				InitJNI();
			}
			protected FilterResults(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _FilterResults11819;
			public FilterResults()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Filter.FilterResults.staticClass, global::android.widget.Filter.FilterResults._FilterResults11819);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _values11820;
			public global::java.lang.Object values
			{
				get
				{
					return default(global::java.lang.Object);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _count11821;
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
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.Filter.FilterResults.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Filter$FilterResults"));
				global::android.widget.Filter.FilterResults._FilterResults11819 = @__env.GetMethodIDNoThrow(global::android.widget.Filter.FilterResults.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _filter11822;
		public virtual void filter(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Filter._filter11822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Filter.staticClass, global::android.widget.Filter._filter11822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void filter(string arg0)
		{
			filter((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _filter11823;
		public virtual void filter(java.lang.CharSequence arg0, android.widget.Filter.FilterListener arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Filter._filter11823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Filter.staticClass, global::android.widget.Filter._filter11823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void filter(string arg0, android.widget.Filter.FilterListener arg1)
		{
			filter((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _performFiltering11824;
		protected abstract global::android.widget.Filter.FilterResults performFiltering(java.lang.CharSequence arg0);
		internal static global::MonoJavaBridge.MethodId _publishResults11825;
		protected abstract void publishResults(java.lang.CharSequence arg0, android.widget.Filter.FilterResults arg1);
		internal static global::MonoJavaBridge.MethodId _convertResultToString11826;
		public virtual global::java.lang.CharSequence convertResultToString(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Filter._convertResultToString11826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Filter.staticClass, global::android.widget.Filter._convertResultToString11826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _Filter11827;
		public Filter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Filter.staticClass, global::android.widget.Filter._Filter11827);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Filter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Filter"));
			global::android.widget.Filter._filter11822 = @__env.GetMethodIDNoThrow(global::android.widget.Filter.staticClass, "filter", "(Ljava/lang/CharSequence;)V");
			global::android.widget.Filter._filter11823 = @__env.GetMethodIDNoThrow(global::android.widget.Filter.staticClass, "filter", "(Ljava/lang/CharSequence;Landroid/widget/Filter$FilterListener;)V");
			global::android.widget.Filter._performFiltering11824 = @__env.GetMethodIDNoThrow(global::android.widget.Filter.staticClass, "performFiltering", "(Ljava/lang/CharSequence;)Landroid/widget/Filter$FilterResults;");
			global::android.widget.Filter._publishResults11825 = @__env.GetMethodIDNoThrow(global::android.widget.Filter.staticClass, "publishResults", "(Ljava/lang/CharSequence;Landroid/widget/Filter$FilterResults;)V");
			global::android.widget.Filter._convertResultToString11826 = @__env.GetMethodIDNoThrow(global::android.widget.Filter.staticClass, "convertResultToString", "(Ljava/lang/Object;)Ljava/lang/CharSequence;");
			global::android.widget.Filter._Filter11827 = @__env.GetMethodIDNoThrow(global::android.widget.Filter.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.Filter))]
	public sealed partial class Filter_ : android.widget.Filter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Filter_()
		{
			InitJNI();
		}
		internal Filter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _performFiltering11828;
		protected override global::android.widget.Filter.FilterResults performFiltering(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Filter_._performFiltering11828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.Filter.FilterResults;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Filter_.staticClass, global::android.widget.Filter_._performFiltering11828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.Filter.FilterResults;
		}
		internal static global::MonoJavaBridge.MethodId _publishResults11829;
		protected override void publishResults(java.lang.CharSequence arg0, android.widget.Filter.FilterResults arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Filter_._publishResults11829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Filter_.staticClass, global::android.widget.Filter_._publishResults11829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Filter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Filter"));
			global::android.widget.Filter_._performFiltering11828 = @__env.GetMethodIDNoThrow(global::android.widget.Filter_.staticClass, "performFiltering", "(Ljava/lang/CharSequence;)Landroid/widget/Filter$FilterResults;");
			global::android.widget.Filter_._publishResults11829 = @__env.GetMethodIDNoThrow(global::android.widget.Filter_.staticClass, "publishResults", "(Ljava/lang/CharSequence;Landroid/widget/Filter$FilterResults;)V");
		}
	}
}
