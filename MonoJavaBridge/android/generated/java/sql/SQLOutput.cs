namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.SQLOutput_))]
	public partial interface SQLOutput  : global::MonoJavaBridge.IJavaObject 
	{
		void writeObject(java.sql.SQLData arg0);
		void writeInt(int arg0);
		void writeBytes(byte[] arg0);
		void writeLong(long arg0);
		void writeByte(byte arg0);
		void writeShort(short arg0);
		void writeFloat(float arg0);
		void writeString(java.lang.String arg0);
		void writeDouble(double arg0);
		void writeArray(java.sql.Array arg0);
		void writeBoolean(bool arg0);
		void writeBigDecimal(java.math.BigDecimal arg0);
		void writeDate(java.sql.Date arg0);
		void writeTime(java.sql.Time arg0);
		void writeTimestamp(java.sql.Timestamp arg0);
		void writeCharacterStream(java.io.Reader arg0);
		void writeAsciiStream(java.io.InputStream arg0);
		void writeBinaryStream(java.io.InputStream arg0);
		void writeRef(java.sql.Ref arg0);
		void writeBlob(java.sql.Blob arg0);
		void writeClob(java.sql.Clob arg0);
		void writeStruct(java.sql.Struct arg0);
		void writeURL(java.net.URL arg0);
		void writeNString(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.SQLOutput))]
	internal sealed partial class SQLOutput_ : java.lang.Object, SQLOutput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SQLOutput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void java.sql.SQLOutput.writeObject(java.sql.SQLData arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeObject", "(Ljava/sql/SQLData;)V", ref global::java.sql.SQLOutput_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void java.sql.SQLOutput.writeInt(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeInt", "(I)V", ref global::java.sql.SQLOutput_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void java.sql.SQLOutput.writeBytes(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeBytes", "([B)V", ref global::java.sql.SQLOutput_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void java.sql.SQLOutput.writeLong(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeLong", "(J)V", ref global::java.sql.SQLOutput_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void java.sql.SQLOutput.writeByte(byte arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeByte", "(B)V", ref global::java.sql.SQLOutput_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void java.sql.SQLOutput.writeShort(short arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeShort", "(S)V", ref global::java.sql.SQLOutput_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void java.sql.SQLOutput.writeFloat(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeFloat", "(F)V", ref global::java.sql.SQLOutput_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void java.sql.SQLOutput.writeString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeString", "(Ljava/lang/String;)V", ref global::java.sql.SQLOutput_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void java.sql.SQLOutput.writeDouble(double arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeDouble", "(D)V", ref global::java.sql.SQLOutput_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void java.sql.SQLOutput.writeArray(java.sql.Array arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeArray", "(Ljava/sql/Array;)V", ref global::java.sql.SQLOutput_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		void java.sql.SQLOutput.writeBoolean(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeBoolean", "(Z)V", ref global::java.sql.SQLOutput_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		void java.sql.SQLOutput.writeBigDecimal(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeBigDecimal", "(Ljava/math/BigDecimal;)V", ref global::java.sql.SQLOutput_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		void java.sql.SQLOutput.writeDate(java.sql.Date arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeDate", "(Ljava/sql/Date;)V", ref global::java.sql.SQLOutput_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		void java.sql.SQLOutput.writeTime(java.sql.Time arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeTime", "(Ljava/sql/Time;)V", ref global::java.sql.SQLOutput_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		void java.sql.SQLOutput.writeTimestamp(java.sql.Timestamp arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeTimestamp", "(Ljava/sql/Timestamp;)V", ref global::java.sql.SQLOutput_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		void java.sql.SQLOutput.writeCharacterStream(java.io.Reader arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeCharacterStream", "(Ljava/io/Reader;)V", ref global::java.sql.SQLOutput_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		void java.sql.SQLOutput.writeAsciiStream(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeAsciiStream", "(Ljava/io/InputStream;)V", ref global::java.sql.SQLOutput_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		void java.sql.SQLOutput.writeBinaryStream(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeBinaryStream", "(Ljava/io/InputStream;)V", ref global::java.sql.SQLOutput_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		void java.sql.SQLOutput.writeRef(java.sql.Ref arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeRef", "(Ljava/sql/Ref;)V", ref global::java.sql.SQLOutput_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		void java.sql.SQLOutput.writeBlob(java.sql.Blob arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeBlob", "(Ljava/sql/Blob;)V", ref global::java.sql.SQLOutput_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		void java.sql.SQLOutput.writeClob(java.sql.Clob arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeClob", "(Ljava/sql/Clob;)V", ref global::java.sql.SQLOutput_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		void java.sql.SQLOutput.writeStruct(java.sql.Struct arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeStruct", "(Ljava/sql/Struct;)V", ref global::java.sql.SQLOutput_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		void java.sql.SQLOutput.writeURL(java.net.URL arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeURL", "(Ljava/net/URL;)V", ref global::java.sql.SQLOutput_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		void java.sql.SQLOutput.writeNString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLOutput_.staticClass, "writeNString", "(Ljava/lang/String;)V", ref global::java.sql.SQLOutput_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SQLOutput_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.SQLOutput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/SQLOutput"));
		}
	}
}
