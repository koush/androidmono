namespace java.lang
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.lang.AbstractStringBuilder_))]
	public abstract partial class AbstractStringBuilder : java.lang.Object, Appendable, CharSequence
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractStringBuilder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString19656;
		public abstract global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _append19657;
		public virtual global::java.lang.AbstractStringBuilder append(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "(J)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._append19657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append19658;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", ref global::java.lang.AbstractStringBuilder._append19658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append19659;
		public virtual global::java.lang.AbstractStringBuilder append(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "(I)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._append19659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append19660;
		public virtual global::java.lang.Appendable append(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "(C)Ljava/lang/Appendable;", ref global::java.lang.AbstractStringBuilder._append19660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append19661;
		public virtual global::java.lang.AbstractStringBuilder append(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "(Z)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._append19661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append19662;
		public virtual global::java.lang.AbstractStringBuilder append(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "([CII)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._append19662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append19663;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", ref global::java.lang.AbstractStringBuilder._append19663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append19664;
		public virtual global::java.lang.AbstractStringBuilder append(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/Object;)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._append19664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append19665;
		public virtual global::java.lang.AbstractStringBuilder append(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/String;)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._append19665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append19666;
		public virtual global::java.lang.AbstractStringBuilder append(java.lang.StringBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/StringBuffer;)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._append19666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append19667;
		public virtual global::java.lang.AbstractStringBuilder append(char[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "([C)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._append19667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append19668;
		public virtual global::java.lang.AbstractStringBuilder append(double arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "(D)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._append19668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _append19669;
		public virtual global::java.lang.AbstractStringBuilder append(float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "(F)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._append19669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf19670;
		public virtual int indexOf(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "indexOf", "(Ljava/lang/String;I)I", ref global::java.lang.AbstractStringBuilder._indexOf19670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf19671;
		public virtual int indexOf(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "indexOf", "(Ljava/lang/String;)I", ref global::java.lang.AbstractStringBuilder._indexOf19671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _length19672;
		public virtual int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "length", "()I", ref global::java.lang.AbstractStringBuilder._length19672);
		}
		internal static global::MonoJavaBridge.MethodId _charAt19673;
		public virtual char charAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "charAt", "(I)C", ref global::java.lang.AbstractStringBuilder._charAt19673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointAt19674;
		public virtual int codePointAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "codePointAt", "(I)I", ref global::java.lang.AbstractStringBuilder._codePointAt19674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointBefore19675;
		public virtual int codePointBefore(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "codePointBefore", "(I)I", ref global::java.lang.AbstractStringBuilder._codePointBefore19675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointCount19676;
		public virtual int codePointCount(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "codePointCount", "(II)I", ref global::java.lang.AbstractStringBuilder._codePointCount19676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _offsetByCodePoints19677;
		public virtual int offsetByCodePoints(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "offsetByCodePoints", "(II)I", ref global::java.lang.AbstractStringBuilder._offsetByCodePoints19677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChars19678;
		public virtual void getChars(int arg0, int arg1, char[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "getChars", "(II[CI)V", ref global::java.lang.AbstractStringBuilder._getChars19678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf19679;
		public virtual int lastIndexOf(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "lastIndexOf", "(Ljava/lang/String;I)I", ref global::java.lang.AbstractStringBuilder._lastIndexOf19679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf19680;
		public virtual int lastIndexOf(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "lastIndexOf", "(Ljava/lang/String;)I", ref global::java.lang.AbstractStringBuilder._lastIndexOf19680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _substring19681;
		public virtual global::java.lang.String substring(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.AbstractStringBuilder.staticClass, "substring", "(II)Ljava/lang/String;", ref global::java.lang.AbstractStringBuilder._substring19681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _substring19682;
		public virtual global::java.lang.String substring(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.AbstractStringBuilder.staticClass, "substring", "(I)Ljava/lang/String;", ref global::java.lang.AbstractStringBuilder._substring19682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _subSequence19683;
		public virtual global::java.lang.CharSequence subSequence(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::java.lang.AbstractStringBuilder.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;", ref global::java.lang.AbstractStringBuilder._subSequence19683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _replace19684;
		public virtual global::java.lang.AbstractStringBuilder replace(int arg0, int arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "replace", "(IILjava/lang/String;)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._replace19684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _trimToSize19685;
		public virtual void trimToSize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "trimToSize", "()V", ref global::java.lang.AbstractStringBuilder._trimToSize19685);
		}
		internal static global::MonoJavaBridge.MethodId _ensureCapacity19686;
		public virtual void ensureCapacity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "ensureCapacity", "(I)V", ref global::java.lang.AbstractStringBuilder._ensureCapacity19686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _capacity19687;
		public virtual int capacity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "capacity", "()I", ref global::java.lang.AbstractStringBuilder._capacity19687);
		}
		internal static global::MonoJavaBridge.MethodId _setLength19688;
		public virtual void setLength(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "setLength", "(I)V", ref global::java.lang.AbstractStringBuilder._setLength19688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCharAt19689;
		public virtual void setCharAt(int arg0, char arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "setCharAt", "(IC)V", ref global::java.lang.AbstractStringBuilder._setCharAt19689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _appendCodePoint19690;
		public virtual global::java.lang.AbstractStringBuilder appendCodePoint(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "appendCodePoint", "(I)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._appendCodePoint19690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _delete19691;
		public virtual global::java.lang.AbstractStringBuilder delete(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "delete", "(II)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._delete19691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _deleteCharAt19692;
		public virtual global::java.lang.AbstractStringBuilder deleteCharAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "deleteCharAt", "(I)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._deleteCharAt19692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert19693;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, char arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IC)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._insert19693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert19694;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(II)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._insert19694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert19695;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IJ)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._insert19695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert19696;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IF)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._insert19696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert19697;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ID)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._insert19697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert19698;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/String;)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._insert19698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert19699;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/Object;)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._insert19699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert19700;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, char[] arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(I[CII)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._insert19700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert19701;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, char[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(I[C)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._insert19701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _insert19702;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, java.lang.CharSequence arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._insert19702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.AbstractStringBuilder;
		}
		public java.lang.AbstractStringBuilder insert(int arg0, string arg1)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _insert19703;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;II)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._insert19703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.lang.AbstractStringBuilder;
		}
		public java.lang.AbstractStringBuilder insert(int arg0, string arg1, int arg2, int arg3)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _insert19704;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IZ)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._insert19704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.AbstractStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _reverse19705;
		public virtual global::java.lang.AbstractStringBuilder reverse()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "reverse", "()Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._reverse19705) as java.lang.AbstractStringBuilder;
		}
		static AbstractStringBuilder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.AbstractStringBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/AbstractStringBuilder"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.AbstractStringBuilder))]
	internal sealed partial class AbstractStringBuilder_ : java.lang.AbstractStringBuilder
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractStringBuilder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString19706;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.AbstractStringBuilder_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.AbstractStringBuilder_._toString19706) as java.lang.String;
		}
		static AbstractStringBuilder_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.AbstractStringBuilder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/AbstractStringBuilder"));
		}
		internal static void InitJNI()
		{
		}
	}
}
