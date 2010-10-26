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
		public partial interface FilterListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onFilterComplete(int arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.Filter.FilterListener))]
		internal sealed partial class FilterListener_ : java.lang.Object, FilterListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static FilterListener_()
			{
				InitJNI();
			}
			internal FilterListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onFilterComplete17074;
			 void android.widget.Filter.FilterListener.onFilterComplete(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Filter.FilterListener_._onFilterComplete17074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Filter.FilterListener_.staticClass, global::android.widget.Filter.FilterListener_._onFilterComplete17074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.Filter.FilterListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Filter$FilterListener"));
				global::android.widget.Filter.FilterListener_._onFilterComplete17074 = @__env.GetMethodIDNoThrow(global::android.widget.Filter.FilterListener_.staticClass, "onFilterComplete", "(I)V");
			}
		}

		public delegate void FilterListenerDelegate(int arg0);

		internal partial class FilterListenerDelegateWrapper : java.lang.Object, FilterListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static FilterListenerDelegateWrapper()
			{
				InitJNI();
			}
			protected FilterListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _FilterListenerDelegateWrapper17075;
			public FilterListenerDelegateWrapper()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Filter.FilterListenerDelegateWrapper.staticClass, global::android.widget.Filter.FilterListenerDelegateWrapper._FilterListenerDelegateWrapper17075);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.Filter.FilterListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Filter_FilterListenerDelegateWrapper"));
				global::android.widget.Filter.FilterListenerDelegateWrapper._FilterListenerDelegateWrapper17075 = @__env.GetMethodIDNoThrow(global::android.widget.Filter.FilterListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
		}
		internal partial class FilterListenerDelegateWrapper
		{
			private FilterListenerDelegate myDelegate;
			public void onFilterComplete(int arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator FilterListenerDelegateWrapper(FilterListenerDelegate d)
			{
				global::android.widget.Filter.FilterListenerDelegateWrapper ret = new global::android.widget.Filter.FilterListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
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
			internal static global::MonoJavaBridge.MethodId _FilterResults17076;
			public FilterResults()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Filter.FilterResults.staticClass, global::android.widget.Filter.FilterResults._FilterResults17076);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _values17077;
			public global::java.lang.Object values
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _values17077)) as java.lang.Object;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _count17078;
			public int count
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _count17078);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.Filter.FilterResults.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Filter$FilterResults"));
				global::android.widget.Filter.FilterResults._FilterResults17076 = @__env.GetMethodIDNoThrow(global::android.widget.Filter.FilterResults.staticClass, "<init>", "()V");
				global::android.widget.Filter.FilterResults._values17077 = @__env.GetFieldIDNoThrow(global::android.widget.Filter.FilterResults.staticClass, "values", "Ljava/lang/Object;");
				global::android.widget.Filter.FilterResults._count17078 = @__env.GetFieldIDNoThrow(global::android.widget.Filter.FilterResults.staticClass, "count", "I");
			}
		}
		internal static global::MonoJavaBridge.MethodId _filter17079;
		public virtual void filter(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Filter._filter17079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Filter.staticClass, global::android.widget.Filter._filter17079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void filter(string arg0)
		{
			filter((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _filter17080;
		public virtual void filter(java.lang.CharSequence arg0, android.widget.Filter.FilterListener arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Filter._filter17080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Filter.staticClass, global::android.widget.Filter._filter17080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void filter(string arg0, global::android.widget.Filter.FilterListenerDelegate arg1)
		{
			filter((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::android.widget.Filter.FilterListenerDelegateWrapper)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _performFiltering17081;
		protected abstract global::android.widget.Filter.FilterResults performFiltering(java.lang.CharSequence arg0);
		internal static global::MonoJavaBridge.MethodId _publishResults17082;
		protected abstract void publishResults(java.lang.CharSequence arg0, android.widget.Filter.FilterResults arg1);
		internal static global::MonoJavaBridge.MethodId _convertResultToString17083;
		public virtual global::java.lang.CharSequence convertResultToString(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Filter._convertResultToString17083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Filter.staticClass, global::android.widget.Filter._convertResultToString17083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _Filter17084;
		public Filter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Filter.staticClass, global::android.widget.Filter._Filter17084);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Filter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Filter"));
			global::android.widget.Filter._filter17079 = @__env.GetMethodIDNoThrow(global::android.widget.Filter.staticClass, "filter", "(Ljava/lang/CharSequence;)V");
			global::android.widget.Filter._filter17080 = @__env.GetMethodIDNoThrow(global::android.widget.Filter.staticClass, "filter", "(Ljava/lang/CharSequence;Landroid/widget/Filter$FilterListener;)V");
			global::android.widget.Filter._performFiltering17081 = @__env.GetMethodIDNoThrow(global::android.widget.Filter.staticClass, "performFiltering", "(Ljava/lang/CharSequence;)Landroid/widget/Filter$FilterResults;");
			global::android.widget.Filter._publishResults17082 = @__env.GetMethodIDNoThrow(global::android.widget.Filter.staticClass, "publishResults", "(Ljava/lang/CharSequence;Landroid/widget/Filter$FilterResults;)V");
			global::android.widget.Filter._convertResultToString17083 = @__env.GetMethodIDNoThrow(global::android.widget.Filter.staticClass, "convertResultToString", "(Ljava/lang/Object;)Ljava/lang/CharSequence;");
			global::android.widget.Filter._Filter17084 = @__env.GetMethodIDNoThrow(global::android.widget.Filter.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.Filter))]
	internal sealed partial class Filter_ : android.widget.Filter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Filter_()
		{
			InitJNI();
		}
		internal Filter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _performFiltering17085;
		protected override global::android.widget.Filter.FilterResults performFiltering(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Filter_._performFiltering17085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.Filter.FilterResults;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Filter_.staticClass, global::android.widget.Filter_._performFiltering17085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.Filter.FilterResults;
		}
		protected android.widget.Filter.FilterResults performFiltering(string arg0)
		{
			return performFiltering((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _publishResults17086;
		protected override void publishResults(java.lang.CharSequence arg0, android.widget.Filter.FilterResults arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Filter_._publishResults17086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Filter_.staticClass, global::android.widget.Filter_._publishResults17086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected void publishResults(string arg0, android.widget.Filter.FilterResults arg1)
		{
			publishResults((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Filter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Filter"));
			global::android.widget.Filter_._performFiltering17085 = @__env.GetMethodIDNoThrow(global::android.widget.Filter_.staticClass, "performFiltering", "(Ljava/lang/CharSequence;)Landroid/widget/Filter$FilterResults;");
			global::android.widget.Filter_._publishResults17086 = @__env.GetMethodIDNoThrow(global::android.widget.Filter_.staticClass, "publishResults", "(Ljava/lang/CharSequence;Landroid/widget/Filter$FilterResults;)V");
		}
	}
}
